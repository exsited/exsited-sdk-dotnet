
namespace Exsited.Client;

/// <summary>A resource with a client pre-applied: the base of every typed resource group.</summary>
public abstract class BoundResource
{
    protected ExsitedClient Client { get; }

    protected BoundResource(ExsitedClient client) => Client = client;
}
