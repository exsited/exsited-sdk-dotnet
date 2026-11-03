# Exsited .NET SDK

.NET client for the Exsited v4 REST API. It handles OAuth2 authentication with a token
cache, retries with backoff, connection pooling, proxies and custom TLS, a typed error
hierarchy and secret redaction, and covers every v4 endpoint. Responses are available as
the raw JSON text, as a dictionary, or as an optional typed view.

## Requirements

- .NET SDK 8.0.100 or newer (the package targets `net8.0`)
- An Exsited instance and an API client: its base URL, client id, client secret and redirect URI

The package has no runtime dependencies.

## Install

```bash
dotnet add package Exsited
```

## Configure credentials

The SDK does not read credentials from the environment itself. Build an `AuthConfig` from
wherever you keep them, for example environment variables, and pass it to the client.

```csharp
using Exsited.Config;

var auth = new AuthConfig(
    baseUrl: Environment.GetEnvironmentVariable("EXSITED_BASE_URL") ?? "https://your-instance.example.com",
    clientId: Environment.GetEnvironmentVariable("EXSITED_CLIENT_ID") ?? "your-client-id",
    clientSecret: Environment.GetEnvironmentVariable("EXSITED_CLIENT_SECRET") ?? "your-client-secret",
    redirectUri: Environment.GetEnvironmentVariable("EXSITED_REDIRECT_URI") ?? "https://your-app.example.com/",
    clientName: "default");
```

All five arguments are required. Missing or invalid values are reported together when
the config is constructed. By default the access token is cached in the per-user cache
directory; pass `tokenCachePath: null` to keep it in memory only.

Behaviour such as retries, timeouts, logging and the response format is set on
`SdkConfig`, whose only required argument is the `AuthConfig`:

```csharp
var config = new SdkConfig(auth, maxRetries: 3, timeoutSeconds: 30.0);
```

## First call

```csharp
using Exsited.Client;
using Exsited.Config;
using Exsited.Resources.Accounts.AccountsDto;

await using var client = new ExsitedClient(new SdkConfig(auth));

var response = await client.Accounts.GetAccountAsync("your-account-id");

if (response.Succeeded)
{
    Console.WriteLine(response.Json);
    Console.WriteLine(response.Dto is Account account ? account.Name : null);
}
```

`response.Map` is the body as a dictionary, `response.Json` is the text exactly as the
API sent it, and `response.Dto` is the typed view. Every endpoint is also available as a
static method that takes the client, for example
`Accounts.GetAccountAsync(client, "your-account-id")`.

## Errors

A failed call comes back as a response with `Succeeded == false` instead of throwing.
Set `raiseOnError: true` on the `SdkConfig`, or on a single call, to throw an
`SdkError` instead. Its `Summary()` is a one-line description and `GetErrorMessages()`
returns the reasons the API gave.

```csharp
using Exsited.Errors;

try
{
    await client.Accounts.GetAccountAsync("your-account-id", raiseOnError: true);
}
catch (SdkError error)
{
    Console.WriteLine(error.Summary());
}
```

## Pagination

Listings are paged in one of two shapes, and the SDK detects which on each page.
`Pagination.IterRecordsAsync` walks a listing lazily and yields one record at a time:

```csharp
using Exsited.Client;
using Exsited.Resources.Payments;

await foreach (var record in Pagination.IterRecordsAsync(
    client, PaymentsUrls.Payments, PaymentsUrls.DataKey))
{
    Console.WriteLine(record["id"]);
}
```

## Documentation

The endpoint reference is at [exsited.mintlify.app](https://exsited.mintlify.app).

## License

MIT, see [LICENSE](LICENSE).
