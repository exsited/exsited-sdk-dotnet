# Exsited .NET SDK (v4)

.NET client for the Exsited v4 REST API. Handles OAuth2 with a cross-process token
cache, retry with backoff, connection pooling, corporate TLS and proxies,
content-type decoding, a typed error hierarchy, secret redaction and terminal
diagnostics, and covers every v4 endpoint under the v4 envelope rules.

**No implicit key-case transformation, and already-encoded text is preserved.** A key
you write is the key that is sent, and a key the API sent is the key you read. A body
handed over as a **string of JSON** goes on the wire byte for byte; a **map or a DTO** is
serialised by the SDK. A JSON body decodes to `Dictionary<string, object?>` /
`List<object?>`, and `ApiResponse.Json` is the response text as it arrived. On top of
that raw path there is an **optional** typed view, `ApiResponse.Dto`.

```csharp
using Exsited.Client;
using Exsited.Config;
using Exsited.Resources.Accounts.AccountsDto;

var auth = new AuthConfig(
    baseUrl: "https://dev-api.exsited.com",
    clientId: "...",
    clientSecret: "...",
    redirectUri: "https://dev.exsited.com/",
    clientName: "default");

await using var client = new ExsitedClient(new SdkConfig(auth));

var response = await client.Accounts.GetAccountAsync("W13ZGY");

Console.WriteLine(response.Map);                  // the body as it arrived
Console.WriteLine(response.Json);                 // the API's own bytes
Console.WriteLine(response.Dto is Account a ? a.Name : null);
```

Every endpoint is also a static method taking the client, so both styles work:

```csharp
var same = await Accounts.GetAccountAsync(client, "W13ZGY");
```

The static form forwards to the instance method, so the two behave the same. A
write refuses a null payload with `SdkUsageError` before anything is sent.

A failed call comes back as a response rather than throwing; `raiseOnError: true` on
the `SdkConfig`, or per call, flips that. `ExsitedClient` is `IAsyncDisposable` and
`IDisposable`, so `await using` closes its HTTP session.

| | |
|---|---|
| Package | [`Exsited`](https://www.nuget.org/packages/Exsited) 4.0.0 on NuGet |
| Namespace root | `Exsited` |
| Target framework | `net8.0`, needs the .NET SDK 8.0.100 or newer |
| Dependencies | none: `System.Text.Json` and `HttpClient` are in the framework |
| Endpoints | 864 in 91 families, documented at [exsited.mintlify.app](https://exsited.mintlify.app/introduction) |

**Async-first.** I/O methods are asynchronous (`Task`, `IAsyncEnumerable`) because
`HttpClient` is async-native, and every one takes a `CancellationToken`.

## Contents

- [Install](#install)
- [Credentials](#credentials)
- [Configuration](#configuration)
- [Multiple instances](#multiple-instances)
- [Authentication](#authentication)
- [Requests](#requests)
  - [Sending a body](#sending-a-body)
- [Pagination](#pagination)
- [Responses](#responses)
  - [Reading a response](#reading-a-response)
- [Errors](#errors)
- [Diagnostics](#diagnostics)
- [Retries](#retries)
- [Transport](#transport)
- [Endpoints](#endpoints)
- [Architecture](#architecture)
  - [The pipeline](#the-pipeline)
  - [Client verbs](#client-verbs)
  - [Design decisions](#design-decisions)
  - [What is fixed by contract](#what-is-fixed-by-contract)
- [Troubleshooting](#troubleshooting)
- [Public API](#public-api)

## Install

```bash
dotnet add package Exsited
```

**Prerequisite: the .NET SDK, 8.0.100 or newer.** The package targets `net8.0` and has
zero runtime dependencies. The package id is `Exsited`; the assembly is `Exsited.dll`
and every namespace starts with `Exsited`, so the code reads `using Exsited.Client;`.

The package holds the assembly, its XML documentation, this README and `LICENSE`; the
matching symbol package on NuGet carries the `.pdb`.

## Credentials

**The SDK reads no credential from the environment.** Build an `AuthConfig` from
wherever your credentials live and hand it to the client, or register it (see
[Multiple instances](#multiple-instances)). It is not environment-blind:
`EXSITED_RESPONSE_FORMAT` is the lowest tier of the response format, `NO_COLOR` and
`TERM` are consulted for colour, and `LOCALAPPDATA`/`XDG_CACHE_HOME` for the token-cache
path. None carries a secret.

| Argument | Required | Default | Notes |
|---|---|---|---|
| `baseUrl` | yes | | Needs an `http(s)://` scheme and a host; trailing `/` trimmed. A query string, a fragment or `user:password@` userinfo is refused |
| `clientId` | yes | | |
| `clientSecret` | yes | | Redacted in `ToString()` |
| `redirectUri` | yes | | Sent in the token request |
| `clientName` | yes | | Label in logs and output; selects the instance by name |
| `grantType` | | `"client_credentials"` | |
| `tokenCachePath` | | `AuthConfig.UseDefaultTokenCache` | The sentinel resolves the platform per-user path, `null` keeps the token in memory, any other string is that file |

Validation runs at construction and reports every problem at once:

```
SdkConfigError: instance default: missing required values: clientSecret
```

## Configuration

`AuthConfig` is **who you are**. Behaviour is `SdkConfig`, whose only required
argument is the `AuthConfig`; everything else is an optional named argument with a
default. Both are immutable and validated at construction, with every problem
reported at once.

```csharp
var config = new SdkConfig(auth,
    printApiInfo: true, maxRetries: 3, logLevel: "DEBUG");
```

| Setting | Default | Notes |
|---|---|---|
| `apiVersion` | `"v4"` | Fills `{api_version}` in every resource path. Accepts `"4"` or `"v4"`. The token grant keeps its own fixed path |
| `timeoutSeconds` | `30.0` | A **hard ceiling on one attempt**: connect, send, headers and body read share it, so a server dribbling a byte at a time cannot hold a call open. A retry arms a fresh ceiling, so budget a whole call as `timeoutSeconds` times `maxRetries` plus backoff, or pass a `CancellationToken` |
| `connectTimeoutSeconds` | `10.0` | The TCP connect and TLS handshake, a tighter bound on that one phase inside the above |
| `maxRetries` | `1` | Total attempts **including the first**, so `1` disables retry |
| `maxResponseBytes` | 64 MiB | How much of one response body is read; one byte over raises a classified `SdkError`. At least 1: there is no "no cap" value |
| `retryableHttpCodes` | `{429,500,502,503,504}` | Inert while `maxRetries` is `1` |
| `unsafeRetryableHttpCodes` | `{}` | The second gate every method outside `GET`/`HEAD`/`OPTIONS`/`TRACE` must also pass. Empty, so by default no state-changing method is replayed on any status |
| `retryBackoffSeconds` | `0.5` | Base for exponential backoff with full jitter |
| `retryBackoffMaxSeconds` | `20.0` | Ceiling for one sleep |
| `verifySsl` | `true` | `false` warns on stderr and logs a WARNING; prefer `caBundle` |
| `caBundle` | `null` | PEM path. Contradicts `verifySsl=false`; a missing or oversized file fails at construction |
| `proxyUrl` | `null` | Applied to `http` and `https` |
| `poolMaxsize` | `10` | The most connections open to one server at once, applied as the handler's `MaxConnectionsPerServer`; a request beyond it waits for a free connection. Ignored when you pass your own handler |
| `defaultHeaders` | `{}` | Sent with every request, held to the header grammar at construction. A `Content-*` default is dropped on a request with no body, and a `Content-Type` default is ignored on a `files` call, where the encoder owns the boundary |
| `raiseOnError` | `false` | `true` throws `SdkError` instead of returning the failed response. "Failed" is `Succeeded == false`, which covers a 2xx whose body names itself `"object": "error"` |
| `userAgent` | `exsited-dotnet-sdk/<version>` | |
| `logLevel` | `"WARNING"` | `DEBUG`/`INFO`/`WARNING`/`ERROR`/`CRITICAL`; gates every sink |
| `logBodies` | `false` | Payload and response in the log, redacted |
| `logFile` | `null` | Also append records to this path, UTF-8, filtered by `logLevel` |
| `printApiInfo` | `false` | Client, method, endpoint, params, status, attempt, elapsed |
| `printRequestPayload` | `false` | Redacted |
| `printResponseBody` | `false` | Bytes summarised, never dumped |
| `printHeaders` | `false` | Redacted |
| `printCurl` | `false` | Copy-pasteable POSIX-shell curl, token redacted |
| `printOnlyOnError` | `false` | Suppress the block on success |
| `printFormat` | `"pretty"` | Or `"compact"`, one line per call starting `exsited \|` |
| `printColor` | `false` | ANSI colour, forced off when stdout is redirected and by `NO_COLOR` or `TERM=dumb` |
| `printMaxChars` | `0` | `0` is unlimited |
| `responseFormat` | `"map"` | Which form `response.Data` takes: `"map"`, `"json"` or `"dto"`. Falls back to `EXSITED_RESPONSE_FORMAT`, then to `"map"`; a per-call argument beats both |
| `maxRequestSpoolBytes` | 32 MiB | How much of one upload stream is copied into the request. A larger stream is sent once, with no retry and no 401 replay |
| `maxRequestBytes` | 64 MiB | The finished request body, framing included |
| `maxRequestSourceBytes` | 64 MiB | The caller's payload across every part |
| `maxMultipartOverheadBytes` | 1 MiB | Multipart framing on one request |
| `maxTokenCacheBytes` | 1 MiB | Only the default is accepted: the token store, which is auth, reads a fixed 1 MiB cap, so any other value is refused |
| `maxCaBundleBytes` | 8 MiB | How much of `caBundle` is imported, checked at construction and again before the import |

Every ceiling is refused below 1 at construction, so none can be switched off;
raise it instead. To narrow one setting without restating the others, derive a
config: `WithOverrides(...)` returns a new one, so one caller's flags never leak
into another's.

```csharp
var noisy = config.WithOverrides(logLevel: "DEBUG", printCurl: true);
```

`null` is the "not supplied" sentinel there, so a field whose value can be `null`
(`caBundle`, `proxyUrl`, `logFile`, `userAgent`, `defaultHeaders`, the two
retry-code sets) cannot be reset to `null` this way; construct a fresh
`SdkConfig` for that.


## Multiple instances

To talk to more than one Exsited instance, declare each as its own `AuthConfig` (or
`SdkConfig`, when instances need their own behaviour) and select between them by name or
index. **The first entry is the default.** Each instance is isolated: its own HTTP
session, token provider and token cache entry. Duplicate `clientName`s are refused.

```csharp
var instances = new object[]
{
    new AuthConfig(clientName: "production", baseUrl: "https://api.exsited.com",
        clientId: "...", clientSecret: "...", redirectUri: "..."),
    new AuthConfig(clientName: "dev", baseUrl: "https://dev-api.exsited.com",
        clientId: "...", clientSecret: "...", redirectUri: "..."),
};

await using var registry = new ClientRegistry(instances);
registry.GetClient();          // the first, the default
registry.GetClient(1);         // by index
registry.GetClient("dev");     // by clientName
```

Or register once and build anywhere:

```csharp
ClientRegistry.RegisterInstances(instances);        // once, at startup
ExsitedClient.BuildClient();                         // the default
ExsitedClient.BuildClient("dev");                    // by clientName
ExsitedClient.BuildClient(configure: c => c.WithOverrides(printApiInfo: true));
ClientRegistry.ListInstanceNames();                  // ("production", "dev")
```

`BuildClient` is `new ExsitedClient(SdkConfig.FromCredentials(blocks, selector))`, so
the factory and the config-level selector cannot disagree.

## Authentication

Automatic. OAuth2 `client_credentials`
against **`POST /api/v4/oauth2/token`**
on first use, cached, and renewed before expiry; a renewal tries the `refresh_token`
grant first and falls back to a full grant. Any 2xx from the token endpoint counts.

A `401` whose body names a token failure (`invalid_token`, `expired_token` and the
other markers read from `code`, `error` and `message`) invalidates the refused token
compare-and-clear, mints a new one and replays the call **once**. A request that cannot
be replayed, one carrying a stream too large to spool, is sent once: its refused token is
still cleared, and the `401` is returned with a WARNING. Any other `401` is returned as
it is.

Token cache location (`AuthConfig.UseDefaultTokenCache`, the default):

| Platform | Path |
|---|---|
| Windows | `%LOCALAPPDATA%\exsited\exsited_dotnet_token.json` |
| macOS | `~/Library/Caches/exsited/exsited_dotnet_token.json` |
| Linux | `$XDG_CACHE_HOME/exsited/exsited_dotnet_token.json`, else `~/.cache/exsited/exsited_dotnet_token.json` |

Never the working tree: the file holds a refresh token. Entries are keyed by a
fingerprint of `baseUrl` + `clientId` + `clientSecret` + `grantType`, so one file serves
many instances. A refresh runs under an exclusive lock on a `<path>.lock` sidecar; a
cache that cannot be read is refused (`SdkTokenCacheError`) rather than read as empty,
and a lock that cannot be taken is refused (`SdkTokenLockError`).

```csharp
new AuthConfig(..., tokenCachePath: null);                          // memory only
new AuthConfig(..., tokenCachePath: "/path/of/your/choosing.json"); // an explicit file
```

## Requests

Two ways to reach an endpoint. The **typed resource** exposes one method per endpoint;
the **raw senders** reach anything by path.

```csharp
await client.SendGetRequestAsync(path, options);      // options: RequestOptions
await client.SendPostRequestAsync(path, options);
await client.SendPutRequestAsync(path, options);
await client.SendPatchRequestAsync(path, options);
await client.SendDeleteRequestAsync(path, options);
await client.SendApiRequestAsync(method, path, options);
```

| `RequestOptions` property | Notes |
|---|---|
| `PathParams` | One per `{name}`; `{api_version}` is filled from config. A missing, extra or blank key throws `SdkUsageError`. A value of only dots, and a `#` in the template, are refused |
| `QueryParams` | Spelled as the API spells them (snake_case in v4); values normalised through one table, and a value with no wire spelling refused |
| `JsonBody` | A map, list or POCO, a **string of raw JSON** sent byte for byte, or a `Dto`, asked for its map. Mutually exclusive with `FormData` and `Files` |
| `FormData` | Form-encoded body |
| `Files` | Multipart; a `byte[]`, a seekable `Stream` (read once into storage the request owns; one larger than `maxRequestSpoolBytes` is sent once, with no retry and no 401 replay) or `[filename, content, contentType?]` |
| `Headers` | Beat `defaultHeaders`; cannot override `Authorization`; held to the header grammar. A `Content-Type` on a `Files` call is refused |
| `Authenticated` | `false` skips the token (default `true`) |
| `RaiseOnError` | Overrides the config for this call |
| `ResponseFormat` | `"map"`, `"json"` or `"dto"`, the highest of the four tiers |
| `DtoType` | Which DTO `response.Dto` builds; the typed resource sets it |

Every collection is snapshotted as it is set, so the caller's dictionaries can change
afterwards without changing the request.

```csharp
await client.SendGetRequestAsync("/api/{api_version}/accounts/{account_id}",
    new RequestOptions { PathParams = new Dictionary<string, object?> { ["account_id"] = "W13ZGY" } });
```

**Query helpers for v4.** `QueryParams.FilterParam` spells a filter (`filter_status`
for `eq`, which carries no suffix; every other comparison is appended), and
`QueryParams.SortParam` / `SortParams` spell the two sorting forms. Sending a family the
sorting form it does not take is accepted and ignored by the API, so check which one a
family takes: Account, Accounting Codes, Alert, Integration Connections and Inventory
Adjustments take `sort` with a `-` prefix; Item, Order, Usage, Purchase Order and
Return Merchandise Authorisation take `order_by` plus `direction`.

### Sending a body

A body is a map, a string of JSON or a `Dto` (asked for its map), through the same method:

```csharp
await client.Accounts.UpdateAccountInformationAsync("W13ZGY",
    new Dictionary<string, object?> { ["account"] = new Dictionary<string, object?> { ["description"] = "..." } });

await client.Accounts.UpdateAccountInformationAsync("W13ZGY", """{"account":{"description":"..."}}""");
```

The map is serialised; the string is sent to the wire byte for byte, never reformatted
or re-keyed, `application/json` either way. A string that does not parse, or whose JSON
is a bare scalar, is refused with `SdkUsageError` before anything is sent. A null
payload is refused the same way by every write.

## Pagination

v4 serves two paging shapes, a cursor and an offset block, and the SDK detects which per
page, because choosing wrong fails silently rather than loudly.

```csharp
await foreach (var page in Pagination.IterPagesAsync(client, PaymentsUrls.Payments))
{
    // one ApiResponse per page
}

await foreach (var record in Pagination.IterRecordsAsync(
    client, PaymentsUrls.Payments, PaymentsUrls.DataKey))
{
    Console.WriteLine(record["id"]);
}
```

Both are lazy, `maxPages` caps the walk, and a failed page throws by default. The next
offset is computed, never read from `next_page`, which is the literal string `"NULL"` at
the end of an offset listing. The record key is the one thing detection cannot guess, so
the `<Family>Urls` class of each of the 80 families with a measured listing carries it as
`DataKey` (`data`); a wrong key is reported with the keys the page actually has.

## Responses

Every call returns an `ApiResponse`:

```csharp
response.StatusCode          // 200
response.Data                // the body, in whichever form responseFormat resolved to
response.Map                 // ALWAYS the decoded map/list/bytes
response.Json                // ALWAYS the API's own body text
response.Dto                 // the typed view, where the endpoint names one
response.ResponseFormat      // "map", "json" or "dto"
response.Headers
response.ContentType
response.Succeeded           // 2xx AND the body does not name itself "object": "error"
response.ErrorType           // ErrorType.NotFound, .Validation, .Timeout, ...
response.GetErrorMessages()
response.RequestInfo         // method, url, params, redacted body and headers, timing
response.RaiseForStatus()    // throws unless Succeeded
```

### Reading a response

`Map`, `Json` and `Dto` are **always all three available**. `ResponseFormat` moves
`Data` and nothing else, through four tiers, highest first: the per-call argument, the
`SdkConfig`, the `EXSITED_RESPONSE_FORMAT` environment variable, then `"map"`.

- `Map` is the decoded body, untouched. It is the only thing that can tell a key the
  API sent as `null` from one it never sent.
- `Json` is the API's own bytes, not a re-serialisation.
- `Dto` is the typed view, where one was measured, and `null` when the call did not
  succeed, so an error envelope never reads as a record of nulls; `Map` still holds it.
  **9 of the 91 families have none**: `aba_files`, because
  its one endpoint has never answered a success, `account_emails`, whose one
  endpoint, a delete, answers an empty body, and `alert_responsibilities`,
  `attribute_attachments`, `communications`, `organisations`, `proforma_invoices`,
  `reconciliations` and `webhooks`, because nothing their endpoints answer has been
  measured.

A DTO converts nothing: a value that is not the declared type reads `null`, and every
value type is nullable, so an absent count is never a real zero.

### The decoded body

`.Map` is the decoded body with **nothing renamed or reshaped**. Decoding follows the
content type:

| Content | `Map` is |
|---|---|
| JSON (`application/json` or any `+json` type) | `Dictionary<string, object?>` / `List<object?>` |
| `text/*` | `string`, by the declared charset, else strict UTF-8, else Latin-1 |
| anything else | `byte[]` |
| empty (a `204`) | `null` |

A body labelled JSON that does not parse is kept as its UTF-8 text rather than dropped.

Inside a decoded JSON body the boxed runtime types are `string`, `bool`, `long`,
`double` and, for an integer literal too wide for `Int64`, `System.Numerics.BigInteger`,
which keeps the digits exact where `double` would drop the low ones. `BigInteger` is not
`IConvertible`, so `Convert.ToDouble` on such a value throws; match on the type, or read
`ToString()`. A DTO field reads `null` for such a value, and `.Map` keeps it exact.

The four PDF endpoints (`GetInvoicePdfAsync`, `GetOrderPdfAsync`,
`GetPurchaseInvoicePdfAsync` and `GetComponentObjectPdfAsync`) name no typed view, and
the order and invoice PDFs answer a JSON descriptor rather than bytes. So check the
type of `.Map` before writing it to disk:

```csharp
var pdf = await client.Invoices.GetInvoicePdfAsync(invoiceId);
if (pdf.Map is byte[] bytes)
    File.WriteAllBytes("invoice.pdf", bytes);   // .Json and .Dto are null for bytes
```

**A `200` is not automatically a success.** `Succeeded` reads one key of the body as
well as the status. Every v4 body names itself with `object`, and an error envelope names
itself `"object": "error"`; one of those arriving under a 2xx status is a failure, not an
empty result:

| Body | Verdict |
|---|---|
| no `object` key, or one naming anything but `error` | unchanged: `Succeeded` follows the status |
| not a mapping: text, bytes, `null` | unchanged |
| `object` is the string `error`, case and surrounding space ignored | **denied**: `Succeeded == false`, `ErrorType.Unknown` |

The check can only move a 2xx from success to failure, never the reverse, and a
`message` key on its own denies nothing. Outside a 2xx it is ignored, so a real `404`
still classifies `NotFound`. `ErrorType.Unknown` rather than a guessed kind, because the
status that `ErrorType` is derived from says nothing about why. `GetErrorMessages()`, on
the response and on `SdkError`, reads the reason off the body, and the envelope itself is
on `Map` and `Json`, and on `SdkError.RawResponse` once raised.

`ErrorType` is derived from the status, not the body. The one exception is the denial
above, and it only decides *whether* a 2xx failed, never how.

| Status | `ErrorType` |
|---|---|
| 2xx | `None`, or `Unknown` when the body denied success |
| 3xx | `Redirect`: not followed; read `Location` off `response.Headers` |
| 400, 422 | `Validation` |
| 401 / 403 | `Authentication` / `Authorization` |
| 404 / 405 / 409 / 429 | `NotFound` / `MethodNotAllowed` / `Conflict` / `RateLimit` |
| 5xx | `Server` |
| timeout / connection failure | `Timeout` / `Network` |
| other | `Unknown` |

**A cancelled request carries no `ErrorType` at all.** `Transport` rethrows
`OperationCanceledException` **unwrapped** when the caller's `CancellationToken` is
cancelled, so cancellation is never classified and never retried, and a cancelled `Task`
lands `Canceled` rather than `Faulted`.

## Errors

A failed call does **not** throw by default: it comes back with `Succeeded == false`.
Opt in to throwing with `raiseOnError: true` on the config or per call:

```csharp
using Exsited.Errors;

try
{
    await client.Accounts.GetAccountAsync("NO-SUCH", raiseOnError: true);
}
catch (SdkError e)
{
    Console.WriteLine(e.Summary());     // one line
    _ = e.StatusCode;
    _ = e.GetErrorMessages();
}
```

`Explain()` is the full diagnostic, secrets redacted twice; `Summary()` is one line.

| Error type | Thrown when |
|---|---|
| `SdkConfigError` | credentials or settings missing or invalid, at construction, listing every problem |
| `SdkUsageError` | a caller mistake caught before any I/O: bad path params, a null payload, an incompatible body |
| `SdkAuthError` | the token endpoint rejected the credentials, or a `401`/`403` |
| `SdkTokenCacheError` / `SdkTokenLockError` | the token cache could not be read, or not locked |
| `SdkAttributeError` | an unknown resource name through `ResourceBinding` |
| `SdkError` | any other failure: a non-2xx, a 2xx whose body names itself an error, a timeout, a connection failure |

All derive from `SdkError`, and each carries `StatusCode`, `ErrorType`, `RawResponse`,
`RequestInfo`, `ResponseHeaders` and `GetErrorMessages()`. `InsecureTransportWarning`
is a type, not a throw: a plain-`http://` non-loopback origin or `verifySsl: false`
writes it to standard error once per message.

## Diagnostics

The `print*` flags render each exchange to the console, secrets redacted:

```csharp
new SdkConfig(auth,
    printApiInfo: true,          // client, method, endpoint, params, status, timing
    printRequestPayload: true,
    printResponseBody: true,     // bytes summarised, never dumped
    printHeaders: true,
    printCurl: true,             // a copy-pasteable POSIX-shell curl, token redacted
    printOnlyOnError: true,
    printFormat: "pretty");      // or "compact"
```

**pretty** opens with a title line and `label: value` rows:

```
Exsited  GET  200  0.0231s
client      : default
api version : v4
method      : GET
endpoint    : https://dev-api.exsited.com/api/v4/accounts
params      : {"limit":1}
status      : 200
attempt     : 1 / 1
elapsed     : 0.0231s
```

**compact** is one line per call:

```
exsited | default | GET | https://dev-api.exsited.com/api/v4/accounts | 200 | 1/1 | 0.0231s
```

Anything from outside the SDK is neutralised before it reaches the terminal: control
characters, `U+007F-U+009F` and `U+2028`/`U+2029` print as `\uXXXX`.

**Logging is separate** from printing. The client takes an optional `Action<string>`
hook, one structured single-line record per exchange, and `logFile` appends the same
records to a file; both are gated by `logLevel`, and the per-exchange record is INFO
while the default level is WARNING. Both paths share one redactor: a key whose name
carries a sensitive marker (`secret`, `password`, `token`, `authorization`, `apikey`,
`cookie`, `session`, `signature` and the rest of `Redaction.SensitiveKeyMarkers`) prints
as `***`.

## Retries

Off by default: `maxRetries` counts the first attempt. Exponential backoff with full
jitter, capped by `retryBackoffMaxSeconds`; a `Retry-After` beats the jitter but is
clamped by the same ceiling.

| | Retried on |
|---|---|
| `GET` `HEAD` `OPTIONS` `TRACE` | `retryableHttpCodes` (default `{429,500,502,503,504}`) |
| every other verb | `retryableHttpCodes` **and** `unsafeRetryableHttpCodes` (default `{}`), so by default nothing |

A failure with no status is retried by delivery stage: one before the request could have
arrived (DNS, connect, TLS, proxy) for any method, one after it only for
`RetryPolicy.IdempotentMethods` (the safe methods, `PUT` and `DELETE`). A `401` is never
retried here; the client's refresh-and-replay handles it above the transport.

## Transport

One `HttpClient` over a `SocketsHttpHandler` per client. Redirects are not followed
(`AllowAutoRedirect` is `false`), pooled connections are retired after five minutes,
responses are decompressed, and `MaxConnectionsPerServer` is `poolMaxsize`. Prefer
`caBundle` over `verifySsl: false`; setting both is refused.

The response is read as a stream and `maxResponseBytes` stops the read: a body one byte
over raises a classified `SdkError` carrying the call's `RequestInfo`. The per-attempt
`timeoutSeconds` ceiling covers the send and the body read together, with a fresh one per
attempt. There is no value that turns a ceiling off.

## Endpoints

**864 endpoints across 91 families**, each reached from the client
(`client.Accounts`, `client.Orders`, `client.Invoices`, ...) and each also a static
method taking the client. Every endpoint, with its request and response bodies, is
documented at [exsited.mintlify.app](https://exsited.mintlify.app/introduction). Each
endpoint has one method, in the family that owns the first segment of its path, except `DELETE /api/{api_version}/component/{component_uuid}`,
which `CustomFeatures.DeleteComponentByIdAsync` and `CustomComponents.DeleteComponentAsync`
both send. 628 endpoints name a typed view; 9 families have none.

The families, by their registered names:

- `aba_files`
- `account_emails`
- `account_groups`
- `accounting_codes`
- `accounts`
- `action_scripts`
- `additional_codes`
- `alert_responsibilities`
- `alert_responsibility`
- `alerts`
- `applications`
- `approval_profiles`
- `approval_user_groups`
- `approvals`
- `attribute_attachments`
- `billing_periods`
- `bookings`
- `charging_periods`
- `communication_profiles`
- `communications`
- `countries`
- `credit_note_applications`
- `credit_notes`
- `custom_attributes`
- `custom_components`
- `custom_events`
- `custom_features`
- `custom_fields`
- `custom_forms`
- `day_of_month`
- `departments`
- `designations`
- `document_templates`
- `email_templates`
- `employees`
- `events`
- `express`
- `external_databases`
- `fulfillment_profiles`
- `fulfillment_terms`
- `gift_certificates`
- `integration_connections`
- `inventory_adjustments`
- `invoice_terms`
- `invoices`
- `item_fulfillments`
- `item_receipts`
- `items`
- `labours`
- `milestones`
- `note_attachments`
- `note_groups`
- `orders`
- `organisation`
- `organisations`
- `payments`
- `portals`
- `pricing_periods`
- `proforma_invoices`
- `purchase_credit_note_applications`
- `purchase_credit_notes`
- `purchase_express`
- `purchase_invoices`
- `purchase_orders`
- `purchase_payments`
- `purchase_refunds`
- `quote_orders`
- `receive_terms`
- `reconciliations`
- `refunds`
- `rental_assets`
- `reports`
- `return_merchandise_authorisations`
- `return_vendor_authorizations`
- `roles`
- `sales_reps`
- `salutations`
- `settings`
- `settings_workflows`
- `shipping_packages`
- `shipping_rules`
- `system_events`
- `tasks`
- `teams`
- `time_periods`
- `timesheets`
- `uom`
- `usages`
- `webhooks`
- `workflows`
- `zones`

## Architecture

How the SDK works inside, and why.

### The pipeline

Objects with one concern each, built per instance and never shared between instances:

```
ExsitedClient ──────────── validation, path/query params, header merge, 401 refresh and replay, printing, logging
  ├─ <Family> (91) ─────── typed endpoints, two call forms (see below)
  ├─ TokenProvider ─────── bearer token from /api/v4/oauth2/token, refreshed before it expires
  │     └─ ITokenStore ─── MemoryTokenStore | FileTokenStore (cross-process, one file)
  ├─ Transport ─────────── HttpClient: timeouts, TLS, proxy, pooling, retries, decoding
  │     └─ RetryPolicy ─── pure decisions: whether, how long, by failure phase and method
  ├─ UrlBuilder / QueryParams ─ RFC 3986 encoding, value normalisation, v4 filter and sort
  ├─ Redaction ─────────── what is a secret (config ToString, logs, prints, curl, errors)
  ├─ Pagination ────────── the v4 cursor or offset walk, IAsyncEnumerable
  └─ FileLogger ────────── the logFile sink: append, UTF-8, refcounted per path
              ▼
        ApiResponse ─────── status, data, headers, errorType, requestInfo
```

The body is settled once, before the token is taken. A `401` naming a token failure
clears the refused token, and refreshes and replays once, above the retry loop, when the
request is replay-safe; that handling is Exsited's own (see
[Authentication](#authentication)). Printing and logging read the redacted `RequestInfo`.

**A family has one implementation per endpoint: its instance method, reached through the
client that owns it**, as `client.Invoices.GetInvoiceAsync(id)`. The client-first static
form, `Invoices.GetInvoiceAsync(client, id)`, forwards to it through `client.Invoices`,
so there is one body per method and not two: 865 of each. The static forms are not
`[Obsolete]`; deprecating a call style is a release decision for this package.

Two orderings are load-bearing, each the answer to a defect:

- **Retry sits inside the transport, beneath the token refresh.** So a `401` is excluded
  from `retryableHttpCodes` (the default is `429, 500, 502, 503, 504`): left in, it would
  replay the same dead token for every attempt and exhaust them before the only layer
  that can mint a new one ever saw the response.
- **Validation sits above the transport, so it costs nothing at runtime.** A bad path
  parameter, a null write payload or an incompatible body combination is a caller mistake
  with a certain outcome; the useful place to report it is where it was written, not as a
  `400` from the server three layers away.

### Client verbs

`SendApiRequestAsync` plus the five wrappers (`SendGetRequestAsync`,
`SendPostRequestAsync`, `SendPutRequestAsync`, `SendPatchRequestAsync`,
`SendDeleteRequestAsync`), `Config`, `Name`, `ListResourceNames()`. Teardown is
`Dispose`/`DisposeAsync`, with `CloseClient()` as the named alias for a caller not using
`await using`. Teardown closes only what the client built: a `Transport` passed to the
constructor stays open and usable afterwards, because a transport is shareable and
disposing one latches it permanently for every other holder.

### Design decisions

- **Async-first.** `HttpClient` is async-native, so the pipeline is `Task`-returning end
  to end, every method takes a `CancellationToken`, and `Pagination` yields
  `IAsyncEnumerable` (`await foreach`).
- **Zero runtime dependencies.** `System.Text.Json` and `HttpClient` are in the BCL;
  nothing is referenced on purpose. Logging is a plain `Action<string>` hook plus the
  `logFile` sink rather than a logging-framework dependency.
- **Validating sealed classes instead of records.** `AuthConfig`/`SdkConfig` are sealed
  classes with validating constructors: a record's `with` would mint an unvalidated
  config and its synthesised `ToString` would print the secrets.
- **`WithOverrides` uses `null` as "not supplied"**, so a field whose *value* can be
  `null` cannot be reset to `null` through it; construct a fresh config for that.
  `FromCredentials`/`BuildClient` take `SdkConfig` or `AuthConfig` blocks or loaded
  mappings, and `BuildClient`'s `configure` argument (`Func<SdkConfig, SdkConfig>`) is
  where a per-call-site override goes.
- **Credentials selection is a config-layer concern**: `SdkConfig.SelectCredentials` /
  `SdkConfig.ReadClientName` decide it. `SdkConfig.FromCredentials` and `ClientRegistry`
  differ in one place on purpose: the registry registers a whole set and refuses
  colliding `clientName`s up front, while `FromCredentials` chooses one entry.
- **Version from packaging.** `SdkConfig.SdkVersion` reads the assembly's
  `AssemblyInformationalVersion` (generated from the csproj `<Version>`), so the
  `User-Agent`, `exsited-dotnet-sdk/4.0.0` for this release, cannot drift from the package.
- **Typed resources.** `client.Accounts`, `client.Invoices` and the other 89 are
  properties, not a dynamic lookup, so the IDE autocompletes every endpoint. Each is also
  registered under its snake_case name (`accounts`, `credit_note_applications`, ...),
  which is what `ResourceBinding.RegisteredResourceNames()` reports and
  `ResourceBinding.ResolveResourceModule` resolves, and the factory hands back the
  client's own cached group, so both ways in are the same object. `SdkAttributeError`
  covers the name-resolution path in `ResourceBinding` and nothing else.
- **A file part may be a seekable `Stream`, seeked back before every attempt** to the
  position it held when the request was built, not to zero, so every attempt sends the
  same remainder the caller offered. An upload is not retried on a status at all, because
  `POST` is outside the idempotent set.
- **One header grammar.** `Transport.IsSendableHeader` is read by the transport, by
  `SdkConfig`'s `defaultHeaders` check and by the client's per-call header check, so a
  pair accepted anywhere is accepted everywhere. The name is the RFC 9110 token; the value
  is printable ASCII with tabs allowed inside, no leading or trailing space or tab, and an
  empty value allowed. A control byte in a header value is a request-smuggling primitive,
  and a non-ASCII one makes `SendAsync` throw an error indistinguishable from a network
  failure, so both are refused before any I/O.
- **`InsecureTransportWarning` is a type, not a throw.** The client writes the message to
  **standard error** and emits it through the log sinks at WARNING, when built over a
  plain-`http://` non-loopback origin or with `verifySsl: false`. Construction succeeds.
  The stderr line is written once per distinct message per process, and
  `InsecureTransportWarning.Suppress` turns it off there only; the WARNING record still
  reaches `onLog` and `logFile`.

### What is fixed by contract

The v4 pagination detection, the query-value normalisation table and its refusals, the
token-cache record format and credential fingerprint, error-message extraction and the
secret-name table are all part of the public contract. Change one and callers break, or
cache files already on disk stop resolving: treat each as a versioned decision rather
than an implementation detail.

## Troubleshooting

| Symptom | Fix |
|---|---|
| `SdkConfigError: instance default: missing required values: ...` | A credential arrived blank: the variable was not set, or the name differs |
| `SdkAuthError` on the first call | The token request is the first thing a call sends; check `baseUrl`, `clientId`, `clientSecret` and `redirectUri` against the instance |
| The token works in one tool and fails here a moment later | A new grant revokes the previous token on Exsited; two processes minting with the same credentials take turns revoking each other |
| A listing comes back unsorted | The family takes the other sorting spelling; see [Requests](#requests) |
| A pager returns only the first page and reports success | The record key is wrong; use `<Family>Urls.DataKey` |
| `CERTIFICATE_VERIFY_FAILED` behind a proxy | `caBundle: "/path/to/ca.pem"`, not `verifySsl: false` |
| `dotnet add package` cannot find the SDK under another name | The package id is `Exsited`, the same as the assembly and the namespace root: `dotnet add package Exsited` |

## Public API

| Namespace | Names |
|---|---|
| `Exsited` | `Redaction` `Dto` `WireNameAttribute` |
| `Exsited.Config` | `AuthConfig` `SdkConfig` |
| `Exsited.Client` | `ExsitedClient` `ClientRegistry` `BoundResource` `ResourceBinding` `ApiResponse` `RequestInfo` `RequestOptions` `ErrorType` `ErrorTypes` `Pagination` `ExchangeConsole` |
| `Exsited.Errors` | `SdkError` `SdkConfigError` `SdkUsageError` `SdkAttributeError` `SdkAuthError` `SdkTokenCacheError` `SdkTokenLockError` `InsecureTransportWarning` |
| `Exsited.Auth` | `ITokenStore` `ITokenRefreshScope` `TokenProvider` `TokenRecord` `TokenCredential` `MemoryTokenStore` `FileTokenStore` |
| `Exsited.Http` | `Transport` `TransportRequest` `RetryPolicy` `UrlBuilder` `QueryParams` `SortDirection` |
| `Exsited.Resources.<Family>` | `<Family>` `<Family>Urls`, for each of the 91 families |
| `Exsited.Resources.<Family>.<Family>Dto` | that family's views |
