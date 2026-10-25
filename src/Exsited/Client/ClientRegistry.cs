using System.Globalization;
using System.Text.RegularExpressions;

using Exsited.Config;
using Exsited.Errors;

namespace Exsited.Client;

/// <summary>Several instances open at once: one cached client per registered block, by position.</summary>
public sealed partial class ClientRegistry : IDisposable, IAsyncDisposable
{
    [GeneratedRegex(@"^<index \d+>$")]
    private static partial Regex IndexLabel();

    private readonly object _gate = new();
    private readonly List<SdkConfig> _blocks = new();
    private readonly Dictionary<string, int> _names = new();
    private readonly List<string> _labels = new();
    private readonly Dictionary<int, ExsitedClient> _clients = new();
    private readonly HashSet<int> _supplied = new();

    public ClientRegistry(IEnumerable<object> credentials)
        : this(credentials, nameof(ClientRegistry))
    {
    }

    // entryPoint names the call the caller made, so the remedy in the message is copy-pasteable.
    private ClientRegistry(IEnumerable<object> credentials, string entryPoint)
    {
        if (credentials is null)
            throw new SdkUsageError(Redaction.RedactMessageText($"{entryPoint} needs at least one credentials block"));
        var position = 0;
        foreach (var block in credentials)
            _blocks.Add(AsConfig(block, position++));
        if (_blocks.Count == 0)
            throw new SdkUsageError(Redaction.RedactMessageText($"{entryPoint} needs at least one credentials block"));
        IndexDeclaredNames();
        // Every block has a validated ClientName, so every label is a name.
        foreach (var block in _blocks)
            _labels.Add(block.ClientName);
    }

    // SdkConfigError, as in SdkConfig.FromCredentials: a wrong-typed entry is a config fault.
    private static SdkConfig AsConfig(object block, int position) => block switch
    {
        SdkConfig config => config,
        AuthConfig auth => new SdkConfig(auth),
        _ => throw new SdkConfigError(Redaction.RedactMessageText($"credentials[{position}]: expected an SdkConfig or an "
            + "AuthConfig, got " + (block?.GetType().Name ?? "null"))),
    };

    private void IndexDeclaredNames()
    {
        for (var index = 0; index < _blocks.Count; index++)
        {
            var name = _blocks[index].ClientName;
            if (_names.TryGetValue(name, out var earlier))
                throw new SdkUsageError(Redaction.RedactMessageText($"two instances share clientName '{name}' (positions "
                    + $"{earlier} and {index}); names must be unique so one can be told from the other"));
            _names[name] = index;
        }
    }

    /// <param name="name"><c>null</c> for the first, an <c>int</c> position, or a <c>clientName</c>.</param>
    public int ResolveIndex(object? name = null)
    {
        switch (name)
        {
            case null:
                return 0;
            case int position:
                {
                    var size = _blocks.Count;
                    if (position >= -size && position < size)
                        return ((position % size) + size) % size;
                    throw new SdkUsageError(Redaction.RedactMessageText(
                        $"no instance at index {position.ToString(CultureInfo.InvariantCulture)}; "
                        + $"{size} registered (0-{size - 1})"));
                }
            case string clientName:
                if (_names.TryGetValue(clientName, out var index))
                    return index;
                throw new SdkUsageError(Redaction.RedactMessageText($"unknown instance '{clientName}'; registered: "
                    + string.Join(", ", _labels)));
            default:
                throw new SdkUsageError("name must be null, an index or a clientName");
        }
    }

    /// <summary>A client for one instance, built and cached on first use.</summary>
    /// <param name="name"><c>null</c> for the first, an <c>int</c> position, or a <c>clientName</c>.</param>
    public ExsitedClient GetClient(object? name = null)
    {
        lock (_gate)
        {
            var index = ResolveIndex(name);
            if (!_clients.TryGetValue(index, out var client))
            {
                client = new ExsitedClient(_blocks[index]);
                _clients[index] = client;
            }
            return client;
        }
    }

    public ExsitedClient GetClient(int index) => GetClient((object)index);

    public ExsitedClient GetClient(string name) => GetClient((object)name);

    /// <summary>Register a pre-built client under a name; its lifetime stays the caller's.</summary>
    public void AddClient(string name, ExsitedClient client)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new SdkUsageError("addClient needs a non-blank name");
        // <index n> reads as a position, so it is reserved.
        if (IndexLabel().IsMatch(name))
            throw new SdkUsageError(Redaction.RedactMessageText($"'{name}' is the label reserved for an "
                + "unnamed entry; pick a name that cannot collide with a position"));
        lock (_gate)
        {
            if (_names.ContainsKey(name) || _labels.Contains(name))
                throw new SdkUsageError(Redaction.RedactMessageText($"instance '{name}' is already registered"));
            _blocks.Add(client.Config);
            var index = _blocks.Count - 1;
            _names[name] = index;
            _labels.Add(name);
            _clients[index] = client;
            _supplied.Add(index);
        }
    }

    /// <summary>One name per instance, default first.</summary>
    public IReadOnlyList<string> ListClientNames()
    {
        lock (_gate)
            return _labels.ToList();
    }

    /// <summary>Close every client this registry built, attempting all even when one fails.</summary>
    public void CloseAllClients()
    {
        var failures = new List<string>();
        Exception? first = null;
        lock (_gate)
        {
            foreach (var (index, client) in _clients.Where(entry => !_supplied.Contains(entry.Key)).ToList())
            {
                try
                {
                    client.Dispose();
                }
                catch (Exception failure)
                {
                    failures.Add($"{_labels[index]}: {failure}");
                    first ??= failure;
                }
            }
            foreach (var index in _clients.Keys.Where(key => !_supplied.Contains(key)).ToList())
                _clients.Remove(index);
        }
        if (first is not null)
            throw new SdkError(Redaction.RedactMessageText($"{failures.Count} client(s) failed to close ("
                + string.Join("; ", failures) + "); all were attempted and dropped"), innerException: first);
    }

    public void Dispose() => CloseAllClients();

    public ValueTask DisposeAsync()
    {
        CloseAllClients();
        return default;
    }

    // The process-wide registration behind ExsitedClient.BuildClient().
    private static readonly object RegistrationLock = new();
    private static IReadOnlyList<SdkConfig> _registered = Array.Empty<SdkConfig>();

    /// <summary>Register every instance this process can talk to; the first is the default.</summary>
    public static void RegisterInstances(IEnumerable<object> credentials)
    {
        // Reuses the collision rules, naming the call the caller made.
        var validated = new ClientRegistry(credentials, nameof(RegisterInstances));
        lock (RegistrationLock)
            _registered = validated._blocks.ToList();
    }

    /// <summary>A snapshot of the registered instances, the first entry the default.</summary>
    public static IReadOnlyList<SdkConfig> GetRegisteredInstances()
    {
        IReadOnlyList<SdkConfig> snapshot;
        lock (RegistrationLock)
            snapshot = _registered;
        if (snapshot.Count == 0)
            throw new SdkUsageError(Redaction.RedactMessageText(NothingRegistered));
        return snapshot.ToList();
    }

    /// <summary>One name per registered instance, default first.</summary>
    public static IReadOnlyList<string> ListInstanceNames() =>
        GetRegisteredInstances().Select(block => block.ClientName).ToList();

    // Names both ways out: the registration, and BuildClient's own credentials argument.
    private const string NothingRegistered =
        "no instances registered - call ClientRegistry.RegisterInstances([...]) first, "
        + "or pass credentials: to BuildClient(...)";

}
