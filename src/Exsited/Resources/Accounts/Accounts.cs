using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Accounts.AccountsDto;

namespace Exsited.Resources.Accounts;

/// <summary>The v4 accounts endpoints, as a typed resource bound to one client.</summary>
public sealed class Accounts : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Accounts</c>.</summary>
    public Accounts(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/accounts</c>.</summary>
    public Task<ApiResponse> GetAccountsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.Accounts,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountAsync(
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.Account,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}</c>.</summary>
    public Task<ApiResponse> GetAccountAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.Account,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/addresses</c>.</summary>
    public Task<ApiResponse> GetAccountAddressesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountAddresses,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountAddresses),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/addresses</c>.</summary>
    public Task<ApiResponse> CreateAccountAddressAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountAddresses,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountImage),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> GetAccountBillingPreferencesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountBillingPreferences),
            }, cancellationToken);

    /// <summary><c>PUT /api/{api_version}/accounts/{account_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> ReplaceAccountBillingPreferencesAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(AccountsUrls.AccountBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountBillingPreferencesUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelAccountAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountCancel),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/contacts</c>.</summary>
    public Task<ApiResponse> GetAccountContactsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountContacts,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountContacts),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/credit_notes</c>.</summary>
    public Task<ApiResponse> GetAccountCreditNotesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCreditNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/custom_objects</c>.</summary>
    public Task<ApiResponse> GetAccountCustomObjectsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCustomObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountCustomObjectList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/image</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountImageAsync(
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountImage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/image</c>.</summary>
    public Task<ApiResponse> GetAccountImageAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountImage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountImageRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/image</c>.</summary>
    public Task<ApiResponse> ImageAccountAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountImage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountImage),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/information</c>.</summary>
    public Task<ApiResponse> GetAccountInformationAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountInformation),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/information</c>.</summary>
    public Task<ApiResponse> UpdateAccountInformationAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountInformationUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/inventories</c>.</summary>
    public Task<ApiResponse> GetAccountInventoriesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountInventories,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountInventories),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/invoices</c>.</summary>
    public Task<ApiResponse> GetAccountInvoicesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/notes</c>.</summary>
    public Task<ApiResponse> GetAccountNotesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateAccountNoteAsync(
        string accountId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(AccountsUrls.AccountNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/orders</c>.</summary>
    public Task<ApiResponse> GetAccountOrdersAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountOrders,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/payment_methods</c>.</summary>
    public Task<ApiResponse> GetAccountPaymentMethodsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPaymentMethods,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountPaymentMethods),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/payments</c>.</summary>
    public Task<ApiResponse> GetAccountPaymentsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/purchase_invoices</c>.</summary>
    public Task<ApiResponse> GetAccountPurchaseInvoicesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPurchaseInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/purchase_orders</c>.</summary>
    public Task<ApiResponse> GetAccountPurchaseOrdersAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPurchaseOrders,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/purchase_payments</c>.</summary>
    public Task<ApiResponse> GetAccountPurchasePaymentsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPurchasePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/purchase_refunds</c>.</summary>
    public Task<ApiResponse> GetAccountPurchaseRefundsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPurchaseRefunds,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/quote_partial_invoices</c>.</summary>
    public Task<ApiResponse> GetAccountQuotePartialInvoicesAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountQuotePartialInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountQuotePartialInvoices),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/refunds</c>.</summary>
    public Task<ApiResponse> GetAccountRefundsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountRefunds,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/set-password</c>.</summary>
    public Task<ApiResponse> SetPasswordAccountAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountSetPassword,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountSetPassword),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}</c>.</summary>
    public Task<ApiResponse> GetAccountAddressAsync(
        string accountId, string subAddressId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountAddress,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_address_id"] = subAddressId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountAddress),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountAddressAsync(
        string accountId, string subAddressId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountAddress,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_address_id"] = subAddressId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}</c>.</summary>
    public Task<ApiResponse> UpdateAccountAddressAsync(
        string accountId, string subAddressId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountAddress,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_address_id"] = subAddressId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountAddressUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/communications/emails</c>.</summary>
    public Task<ApiResponse> GetAccountCommunicationsEmailsAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCommunicationsEmails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountCommunicationsEmailList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}</c>.</summary>
    public Task<ApiResponse> GetAccountContactAsync(
        string accountId, string subContactId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountContact,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_contact_id"] = subContactId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountContact),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountContactAsync(
        string accountId, string subContactId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountContact,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_contact_id"] = subContactId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}</c>.</summary>
    public Task<ApiResponse> UpdateAccountContactAsync(
        string accountId, string subContactId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountContact,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_contact_id"] = subContactId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountContactUpdated),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}</c>.</summary>
    public Task<ApiResponse> ReplaceAccountContactAsync(
        string accountId, string subContactId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(AccountsUrls.AccountContact,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_contact_id"] = subContactId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountContactUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/notes/{account_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountNoteAsync(
        string accountId, string accountNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["account_note_id"] = accountNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/notes/{account_note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdateAccountNoteAsync(
        string accountId, string accountNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["account_note_id"] = accountNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/notes/{account_note_id}</c>.</summary>
    public Task<ApiResponse> GetAccountNoteAsync(
        string accountId, string accountNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["account_note_id"] = accountNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNote),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}</c>.</summary>
    public Task<ApiResponse> GetAccountPaymentMethodAsync(
        string accountId, string subPmId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_pm_id"] = subPmId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountPaymentMethod),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountPaymentMethodAsync(
        string accountId, string subPmId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_pm_id"] = subPmId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}</c>.</summary>
    public Task<ApiResponse> UpdateAccountPaymentMethodAsync(
        string accountId, string subPmId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_pm_id"] = subPmId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountPaymentMethodUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/communications/emails/{email_id}</c>.</summary>
    public Task<ApiResponse> GetAccountCommunicationsEmailAsync(
        string accountId, string emailId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCommunicationsEmail,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["email_id"] = emailId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountCommunicationsEmail),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files</c>.</summary>
    public Task<ApiResponse> GetAccountNoteFilesAsync(
        string accountId, string noteUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["note_uuid"] = noteUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files/{file_uuid}</c>.</summary>
    public Task<ApiResponse> GetAccountNoteFileAsync(
        string accountId, string noteUuid, string fileUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["note_uuid"] = noteUuid, ["file_uuid"] = fileUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/kpis</c>.</summary>
    public Task<ApiResponse> GetAccountKpisAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountKpis),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/financial_summary</c>.</summary>
    public Task<ApiResponse> GetAccountFinancialSummaryAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountFinancialSummary,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountFinancialSummary),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetAccountCustomObjectAsync(
        string accountId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountCustomObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}/instances/{custom_object_instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetAccountCustomObjectInstanceAsync(
        string accountId, string customObjectId, string customObjectInstanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountCustomObjectInstanceOf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["custom_object_id"] = customObjectId, ["custom_object_instance_id"] = customObjectInstanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/component/{component_id}</c>.</summary>
    public Task<ApiResponse> GetAccountComponentObjectsAsync(
        string accountId, string componentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountComponentObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["component_id"] = componentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjects),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/accounts/{account_id}/component/{component_id}/{component_object_id}</c>.</summary>
    public Task<ApiResponse> GetAccountComponentObjectAsync(
        string accountId, string componentId, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountsUrls.AccountComponentObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["component_id"] = componentId, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountComponentObject),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/accounts</c>.</summary>
    public Task<ApiResponse> CreateAccountAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.Accounts,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/accounts/{account_id}</c>.</summary>
    public Task<ApiResponse> ReplaceAccountAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(AccountsUrls.Account,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivateAccountAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/contacts</c>.</summary>
    public Task<ApiResponse> CreateAccountContactsAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountContacts,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/accounts/{account_id}/addresses/{address_id}</c>.</summary>
    public Task<ApiResponse> ReplaceAccountAddressAsync(
        string accountId, string addressId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(AccountsUrls.AccountAddress,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_address_id"] = addressId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/payment_methods</c>.</summary>
    public Task<ApiResponse> CreateAccountPaymentMethodAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountPaymentMethods,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/accounts/{account_id}/payment_methods/{payment_method_id}</c>.</summary>
    public Task<ApiResponse> ReplaceAccountPaymentMethodAsync(
        string accountId, string paymentMethodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(AccountsUrls.AccountPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["sub_pm_id"] = paymentMethodId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateAccountCustomObjectInstanceAsync(
        string accountId, string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["custom_object_id"] = customObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/accounts/{account_id}/custom_objects_instances/{custom_object_instance_id}</c>.</summary>
    public Task<ApiResponse> UpdateAccountCustomObjectInstanceAsync(
        string accountId, string customObjectInstanceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountsUrls.AccountCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["custom_object_instance_id"] = customObjectInstanceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Account),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/communications/emails</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> SendAccountEmailAsync(
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountsUrls.AccountCommunicationsEmails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/accounts/{account_id}/purge</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PurgeAccountAsync(
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(AccountsUrls.AccountPurge,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountNoteFileAsync(
        string accountId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountsUrls.AccountNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["note_uuid"] = noteId, ["file_uuid"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountAsync(
        ExsitedClient client,
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountAsync(
            accountId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountAddressesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountAddressesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountAddressesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountAddressAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountAddressAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountAddressAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountBillingPreferencesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountBillingPreferencesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReplaceAccountBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceAccountBillingPreferencesAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReplaceAccountBillingPreferencesAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CancelAccountAsync</c>.</summary>
    public static Task<ApiResponse> CancelAccountAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CancelAccountAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountContactsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountContactsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountContactsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCreditNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCreditNotesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCreditNotesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCustomObjectsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCustomObjectsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountImageAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountImageAsync(
        ExsitedClient client,
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountImageAsync(
            accountId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountImageAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountImageAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountImageAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ImageAccountAsync</c>.</summary>
    public static Task<ApiResponse> ImageAccountAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ImageAccountAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountInformationAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountInformationAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountInformationAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountInformationAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountInventoriesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountInventoriesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountInvoicesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountInvoicesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountNotesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountNotesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountNoteAsync(
        ExsitedClient client,
        string accountId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountNoteAsync(
            accountId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountOrdersAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountOrdersAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountOrdersAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPaymentMethodsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPaymentMethodsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPaymentMethodsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPaymentsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPaymentsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPurchaseInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPurchaseInvoicesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPurchaseInvoicesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPurchaseOrdersAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPurchaseOrdersAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPurchaseOrdersAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPurchasePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPurchasePaymentsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPurchasePaymentsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPurchaseRefundsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPurchaseRefundsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPurchaseRefundsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountQuotePartialInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountQuotePartialInvoicesAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountQuotePartialInvoicesAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountRefundsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountRefundsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountRefundsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.SetPasswordAccountAsync</c>.</summary>
    public static Task<ApiResponse> SetPasswordAccountAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.SetPasswordAccountAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountAddressAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountAddressAsync(
        ExsitedClient client,
        string accountId, string subAddressId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountAddressAsync(
            accountId, subAddressId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountAddressAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountAddressAsync(
        ExsitedClient client,
        string accountId, string subAddressId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountAddressAsync(
            accountId, subAddressId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountAddressAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountAddressAsync(
        ExsitedClient client,
        string accountId, string subAddressId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountAddressAsync(
            accountId, subAddressId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCommunicationsEmailsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCommunicationsEmailsAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCommunicationsEmailsAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountContactAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountContactAsync(
        ExsitedClient client,
        string accountId, string subContactId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountContactAsync(
            accountId, subContactId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountContactAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountContactAsync(
        ExsitedClient client,
        string accountId, string subContactId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountContactAsync(
            accountId, subContactId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountContactAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountContactAsync(
        ExsitedClient client,
        string accountId, string subContactId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountContactAsync(
            accountId, subContactId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReplaceAccountContactAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceAccountContactAsync(
        ExsitedClient client,
        string accountId, string subContactId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReplaceAccountContactAsync(
            accountId, subContactId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountNoteAsync(
        ExsitedClient client,
        string accountId, string accountNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountNoteAsync(
            accountId, accountNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountNoteAsync(
        ExsitedClient client,
        string accountId, string accountNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountNoteAsync(
            accountId, accountNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountNoteAsync(
        ExsitedClient client,
        string accountId, string accountNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountNoteAsync(
            accountId, accountNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountPaymentMethodAsync(
        ExsitedClient client,
        string accountId, string subPmId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountPaymentMethodAsync(
            accountId, subPmId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountPaymentMethodAsync(
        ExsitedClient client,
        string accountId, string subPmId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountPaymentMethodAsync(
            accountId, subPmId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountPaymentMethodAsync(
        ExsitedClient client,
        string accountId, string subPmId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountPaymentMethodAsync(
            accountId, subPmId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCommunicationsEmailAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCommunicationsEmailAsync(
        ExsitedClient client,
        string accountId, string emailId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCommunicationsEmailAsync(
            accountId, emailId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountNoteFilesAsync(
        ExsitedClient client,
        string accountId, string noteUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountNoteFilesAsync(
            accountId, noteUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountNoteFileAsync(
        ExsitedClient client,
        string accountId, string noteUuid, string fileUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountNoteFileAsync(
            accountId, noteUuid, fileUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Accounts.GetAccountKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountKpisAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountKpisAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountFinancialSummaryAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountFinancialSummaryAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountFinancialSummaryAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCustomObjectAsync(
        ExsitedClient client,
        string accountId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCustomObjectAsync(
            accountId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountCustomObjectInstanceAsync(
        ExsitedClient client,
        string accountId, string customObjectId, string customObjectInstanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountCustomObjectInstanceAsync(
            accountId, customObjectId, customObjectInstanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountComponentObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountComponentObjectsAsync(
        ExsitedClient client,
        string accountId, string componentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountComponentObjectsAsync(
            accountId, componentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.GetAccountComponentObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetAccountComponentObjectAsync(
        ExsitedClient client,
        string accountId, string componentId, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.GetAccountComponentObjectAsync(
            accountId, componentId, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReplaceAccountAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceAccountAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReplaceAccountAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReactivateAccountAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateAccountAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReactivateAccountAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountContactsAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountContactsAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountContactsAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReplaceAccountAddressAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceAccountAddressAsync(
        ExsitedClient client,
        string accountId, string addressId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReplaceAccountAddressAsync(
            accountId, addressId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountPaymentMethodAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountPaymentMethodAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.ReplaceAccountPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceAccountPaymentMethodAsync(
        ExsitedClient client,
        string accountId, string paymentMethodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.ReplaceAccountPaymentMethodAsync(
            accountId, paymentMethodId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.CreateAccountCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> CreateAccountCustomObjectInstanceAsync(
        ExsitedClient client,
        string accountId, string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.CreateAccountCustomObjectInstanceAsync(
            accountId, customObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.UpdateAccountCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAccountCustomObjectInstanceAsync(
        ExsitedClient client,
        string accountId, string customObjectInstanceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.UpdateAccountCustomObjectInstanceAsync(
            accountId, customObjectInstanceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.SendAccountEmailAsync</c>.</summary>
    public static Task<ApiResponse> SendAccountEmailAsync(
        ExsitedClient client,
        string accountId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.SendAccountEmailAsync(
            accountId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.PurgeAccountAsync</c>.</summary>
    public static Task<ApiResponse> PurgeAccountAsync(
        ExsitedClient client,
        string accountId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.PurgeAccountAsync(
            accountId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Accounts.DeleteAccountNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountNoteFileAsync(
        ExsitedClient client,
        string accountId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Accounts.DeleteAccountNoteFileAsync(
            accountId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
