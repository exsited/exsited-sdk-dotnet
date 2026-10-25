using System.Collections;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text;

using Exsited.Errors;

namespace Exsited;

/// <summary>Declares a DTO property's wire name where the naming convention cannot derive it.</summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class WireNameAttribute : Attribute
{
    public WireNameAttribute(string name) => Name = name;

    public string Name { get; }
}

/// <summary>The typed view over a body: properties map to snake_case wire names, and nothing is coerced.</summary>
public abstract class Dto
{
    /// <summary>The key the API wraps this record in, unwrapped when present.</summary>
    protected virtual string? EnvelopeKey => null;

    /// <summary>Wire names that sit beside the envelope rather than inside it.</summary>
    protected virtual IReadOnlyList<string> TopLevel => Array.Empty<string>();

    // Resolved once per subclass: reflection over a type is not free and its answer cannot change.
    private static readonly ConcurrentDictionary<Type, (string Wire, PropertyInfo Property)[]> Resolved = new();

    /// <summary>This type's fields, in declaration order, mapped to the type each holds.</summary>
    public static IReadOnlyDictionary<string, Type> Fields(Type dtoType)
    {
        var fields = new Dictionary<string, Type>(StringComparer.Ordinal);
        foreach (var (wire, property) in Declarations(dtoType))
            fields[wire] = Unwrap(property.PropertyType);
        return fields;
    }

    /// <summary>Read a decoded body into a DTO of the given type, unwrapping its envelope.</summary>
    public static Dto Build(Type dtoType, IReadOnlyDictionary<string, object?> body)
    {
        if (!typeof(Dto).IsAssignableFrom(dtoType) || dtoType.IsAbstract)
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"dtoType: {dtoType.Name} cannot be built from a response - a typed view has to "
                + "be a concrete subclass of Dto"));

        var dto = (Dto)Activator.CreateInstance(dtoType)!;
        var source = dto.ReadSource(body);

        foreach (var (wire, property) in Declarations(dtoType))
            if (source.TryGetValue(wire, out var value))
                property.SetValue(dto, Read(value, Unwrap(property.PropertyType)));

        return dto;
    }

    /// <summary>The record this type reads its fields out of: the body with its envelope unwrapped.</summary>
    protected virtual IReadOnlyDictionary<string, object?> ReadSource(
        IReadOnlyDictionary<string, object?> body)
    {
        if (EnvelopeKey is not string key
            || !body.TryGetValue(key, out var inner)
            || inner is not IReadOnlyDictionary<string, object?> record)
        {
            return body;
        }

        // Envelope siblings come along, as transaction_no sits beside the record; they win a collision.
        var merged = new Dictionary<string, object?>(record, StringComparer.Ordinal);
        foreach (var (name, value) in body)
            if (!string.Equals(name, key, StringComparison.Ordinal))
                merged[name] = value;
        return merged;
    }

    /// <summary>Read a decoded body into this type - <see cref="Build"/> without the cast.</summary>
    public static TDto FromMap<TDto>(IReadOnlyDictionary<string, object?> body) where TDto : Dto =>
        (TDto)Build(typeof(TDto), body);

    /// <summary>The body this DTO stands for, envelope included; a <c>null</c> field is omitted.</summary>
    public IReadOnlyDictionary<string, object?> ToMap()
    {
        var record = new Dictionary<string, object?>(StringComparer.Ordinal);
        var beside = new Dictionary<string, object?>(StringComparer.Ordinal);
        var topLevel = TopLevel;

        foreach (var (wire, property) in Declarations(GetType()))
        {
            var value = property.GetValue(this);
            if (value is null)
                continue;
            (topLevel.Contains(wire, StringComparer.Ordinal) ? beside : record)[wire] = Write(value);
        }

        var body = EnvelopeKey is string key
            ? new Dictionary<string, object?>(StringComparer.Ordinal) { [key] = record }
            : new Dictionary<string, object?>(record, StringComparer.Ordinal);
        foreach (var (name, value) in beside)
            body[name] = value;
        return body;
    }

    // Metadata-token order is written order, and load-bearing: ToMap writes the body in it.
    private static (string Wire, PropertyInfo Property)[] Declarations(Type dtoType) =>
        Resolved.GetOrAdd(dtoType, type => type
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(property => property.MetadataToken)
            // An explicit WireName wins over the convention.
            .Select(property => (
                property.GetCustomAttribute<WireNameAttribute>()?.Name ?? WireName(property.Name),
                property))
            .ToArray());

    // A digit starts a word only after a lower-case letter: address_line_1 but b2b_configuration.
    private static string WireName(string propertyName)
    {
        var wire = new StringBuilder(propertyName.Length + 8);
        for (var index = 0; index < propertyName.Length; index++)
        {
            var letter = propertyName[index];
            var startsWord = index > 0
                && (char.IsUpper(letter)
                    || (char.IsDigit(letter) && char.IsLower(propertyName[index - 1])));
            if (startsWord)
                wire.Append('_');
            wire.Append(char.ToLowerInvariant(letter));
        }
        return wire.ToString();
    }

    // Every field is optional, so the ? says nothing and is unwrapped.
    private static Type Unwrap(Type declared) => Nullable.GetUnderlyingType(declared) ?? declared;

    private static object? Read(object? value, Type declared)
    {
        if (value is null)
            return null;

        if (declared.IsGenericType && declared.GetGenericTypeDefinition() == typeof(IReadOnlyList<>))
        {
            // A mistyped entry reads null in place, so a page cannot quietly come back a row short.
            if (value is string || value is not IEnumerable sequence)
                return null;
            var itemType = declared.GetGenericArguments()[0];
            var items = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType))!;
            foreach (var item in sequence)
                items.Add(Read(item, itemType));
            return items;
        }

        if (typeof(Dto).IsAssignableFrom(declared))
            return value is IReadOnlyDictionary<string, object?> mapping ? Build(declared, mapping) : null;

        // A field typed object claims nothing, so nothing can fail to match.
        if (declared == typeof(object))
            return value;

        if (declared == typeof(double))
            // The one widening allowed: JSON has one number type, so a long may fill a double.
            return value switch { double number => number, long whole => (double)whole, _ => null };

        // A BigInteger is not narrowed: the field reads null and Map keeps the number exact.
        if (declared == typeof(long))
            return value is long whole ? whole : null;

        if (declared == typeof(bool))
            return value is bool flag ? flag : null;

        return declared.IsInstanceOfType(value) ? value : null;
    }

    // A nested DTO becomes its record and a list is walked; anything else is itself.
    private static object? Write(object? value)
    {
        if (value is Dto nested)
        {
            var record = nested.ToMap();
            // Nested inside its parent's record, so its own envelope would be an extra layer.
            return nested.EnvelopeKey is string key ? record[key] : record;
        }
        if (value is string)
            return value;
        if (value is IReadOnlyDictionary<string, object?> mapping)
        {
            var written = new Dictionary<string, object?>(StringComparer.Ordinal);
            foreach (var (name, item) in mapping)
                written[name] = Write(item);
            return written;
        }
        if (value is IEnumerable sequence)
            return sequence.Cast<object?>().Select(Write).ToList();
        return value;
    }
}
