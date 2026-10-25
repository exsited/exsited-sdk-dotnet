using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Settings.SettingsDto;

namespace Exsited.Resources.Settings;

/// <summary>The v4 settings endpoints, as a typed resource bound to one client.</summary>
public sealed class Settings : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Settings</c>.</summary>
    public Settings(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/custom_objects</c>.</summary>
    public Task<ApiResponse> GetCustomObjectsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.CustomObjects,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomObjectList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings</c>.</summary>
    public Task<ApiResponse> GetSettingsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.Settings,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetCustomObjectAsync(
        string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.CustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjects),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/currencies</c>.</summary>
    public Task<ApiResponse> GetSettingsCurrenciesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCurrencies,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCurrencyList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/custom_logic_scripts</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomLogicScriptsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCustomLogicScripts,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomLogicScripts),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/custom_objects</c>.</summary>
    public Task<ApiResponse> CreateSettingsCustomObjectAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsCustomObjects,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjects),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/discount_profiles</c>.</summary>
    public Task<ApiResponse> GetSettingsDiscountProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsDiscountProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDiscountProfileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/item_groups</c>.</summary>
    public Task<ApiResponse> GetSettingsItemGroupsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsItemGroups,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsItemGroupList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/item_groups</c>.</summary>
    public Task<ApiResponse> CreateSettingsItemGroupAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsItemGroups,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsItemGroups),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/payment_processors</c>.</summary>
    public Task<ApiResponse> GetSettingsPaymentProcessorsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPaymentProcessors,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentProcessorList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/payment_terms</c>.</summary>
    public Task<ApiResponse> GetSettingsPaymentTermsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPaymentTerms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentTermList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/pricing_levels</c>.</summary>
    public Task<ApiResponse> GetSettingsPricingLevelsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPricingLevels,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingLevelList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/shipping_profiles</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsShippingProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingProfileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/taxes</c>.</summary>
    public Task<ApiResponse> GetSettingsTaxesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsTaxes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTaxList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/time_zones</c>.</summary>
    public Task<ApiResponse> GetSettingsTimeZonesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsTimeZones,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimeZoneList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/variations</c>.</summary>
    public Task<ApiResponse> GetSettingsVariationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsVariations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsVariationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/variations</c>.</summary>
    public Task<ApiResponse> CreateSettingsVariationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsVariations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsVariations),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/warehouses</c>.</summary>
    public Task<ApiResponse> GetSettingsWarehousesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsWarehouses,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWarehouseList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/currencies/{currency_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCurrencyAsync(
        string currencyId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCurrency,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["currency_id"] = currencyId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCurrencyRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomLogicScriptAsync(
        string customLogicScriptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCustomLogicScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_logic_script_id"] = customLogicScriptId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomLogicScript),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsCustomObjectAsync(
        string customObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCustomObjectAsync(
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjects),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/field_settings/account</c>.</summary>
    public Task<ApiResponse> UpdateSettingsFieldSettingsAccountAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsFieldSettingsAccount,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFieldSettingsAccountList),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/field_settings/item</c>.</summary>
    public Task<ApiResponse> UpdateSettingsFieldSettingsItemAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsFieldSettingsItem,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFieldSettingsItemList),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/account</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsAccountAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsAccount,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettingsAccount),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/item</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsItemAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsItem,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettingsItem),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/item_groups/{item_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsItemGroupAsync(
        string itemGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsItemGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_group_id"] = itemGroupId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/item_groups/{item_group_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsItemGroupAsync(
        string itemGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsItemGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_group_id"] = itemGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsItemGroups),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/item_groups/{item_group_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsItemGroupAsync(
        string itemGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsItemGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_group_id"] = itemGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsItemGroups),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/time_zones/{time_zone_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsTimeZoneAsync(
        string timeZoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsTimeZone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["time_zone_id"] = timeZoneId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimeZoneRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/variations/{variation_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsVariationAsync(
        string variationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsVariation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["variation_id"] = variationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsVariations),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/variations/{variation_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsVariationAsync(
        string variationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsVariation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["variation_id"] = variationId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsVariations),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/settings/custom_objects/{custom_object_id}/customize</c>.</summary>
    public Task<ApiResponse> CreateSettingsCustomObjectCustomizeAsync(
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsCustomObjectCustomize,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjectCustomize),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/settings/item_groups/{item_group_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> CreateSettingsItemGroupBillingPreferenceAsync(
        string itemGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsItemGroupBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_group_id"] = itemGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsItemGroups),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_objects</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomObjectsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCustomObjects,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjectDefinitionList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomObjectAsync(
        string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjectDefinitionRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/custom_objects</c>.</summary>
    public Task<ApiResponse> CreateCustomObjectAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.CustomObjects,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjects),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> UpdateCustomObjectAsync(
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.CustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomObjects),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteCustomObjectAsync(
        string customObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.CustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_object_id"] = customObjectId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/currencies</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsCurrencyAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsCurrencies,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/currencies/{currency_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCurrencyAsync(
        string currencyId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsCurrency,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["currency_id"] = currencyId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/settings/custom_logic_scripts</c>.</summary>
    public Task<ApiResponse> CreateSettingsCustomLogicScriptAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsCustomLogicScripts,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomLogicScriptSaved),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCustomLogicScriptAsync(
        string customLogicScriptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsCustomLogicScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_logic_script_id"] = customLogicScriptId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomLogicScriptSaved),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsCustomLogicScriptAsync(
        string customLogicScriptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsCustomLogicScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_logic_script_id"] = customLogicScriptId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/discount_profiles</c>.</summary>
    public Task<ApiResponse> CreateSettingsDiscountProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsDiscountProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDiscountProfileRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/discount_profiles/{discount_profile_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsDiscountProfileAsync(
        string discountProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsDiscountProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["discount_profile_id"] = discountProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDiscountProfileRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/discount_profiles/{discount_profile_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsDiscountProfileAsync(
        string discountProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsDiscountProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["discount_profile_id"] = discountProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDiscountProfileRead),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/discount_profiles/{discount_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsDiscountProfileAsync(
        string discountProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsDiscountProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["discount_profile_id"] = discountProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/field_settings</c>.</summary>
    public Task<ApiResponse> GetSettingsFieldSettingsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsFieldSettings,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFieldSettingList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/field_settings/{field_setting_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsFieldSettingAsync(
        string fieldSettingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsFieldSetting,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["field_setting_id"] = fieldSettingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFieldSettingRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/general_settings/{group}</c>.</summary>
    public Task<ApiResponse> GetSettingsGeneralSettingsAsync(
        string group, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsGeneralSettingsGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["group"] = group },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/general_settings/{group}/{general_setting_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetSettingsGeneralSettingAsync(
        string group, string generalSettingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsGeneralSetting,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["group"] = group, ["general_setting_id"] = generalSettingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/dashboard</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsDashboardAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsDashboard,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/date_and_time</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsDateAndTimeAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsDateAndTime,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/display</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsDisplayAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsDisplay,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/general</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsGeneralAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsGeneral,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/labour</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsLabourAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsLabour,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/order</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsOrderAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsOrder,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/portal</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsPortalAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsPortal,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/purchase</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsPurchaseAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsPurchase,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/security</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsSecurityAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsSecurity,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/settings/general_settings/transaction</c>.</summary>
    public Task<ApiResponse> UpdateSettingsGeneralSettingsTransactionAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsGeneralSettingsTransaction,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsGeneralSettings),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/settings/payment_processors</c>.</summary>
    public Task<ApiResponse> CreateSettingsPaymentProcessorAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsPaymentProcessors,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentProcessorSaved),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/payment_processors/{payment_processor_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsPaymentProcessorAsync(
        string paymentProcessorId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPaymentProcessor,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_processor_id"] = paymentProcessorId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentProcessorRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/payment_processors/{payment_processor_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsPaymentProcessorAsync(
        string paymentProcessorId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsPaymentProcessor,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_processor_id"] = paymentProcessorId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentProcessorSaved),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/payment_processors/{payment_processor_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsPaymentProcessorAsync(
        string paymentProcessorId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsPaymentProcessor,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_processor_id"] = paymentProcessorId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/payment_terms</c>.</summary>
    public Task<ApiResponse> CreateSettingsPaymentTermAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsPaymentTerms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentTermCreated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/payment_terms/{payment_term_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsPaymentTermAsync(
        string paymentTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPaymentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_term_id"] = paymentTermId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentTermRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/payment_terms/{payment_term_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsPaymentTermAsync(
        string paymentTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsPaymentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_term_id"] = paymentTermId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPaymentTermUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/payment_terms/{payment_term_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsPaymentTermAsync(
        string paymentTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsPaymentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_term_id"] = paymentTermId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/pricing_levels</c>.</summary>
    public Task<ApiResponse> CreateSettingsPricingLevelAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsPricingLevels,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingLevelCreated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/pricing_levels/{pricing_level_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsPricingLevelAsync(
        string pricingLevelId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsPricingLevel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_level_id"] = pricingLevelId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingLevelRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/pricing_levels/{pricing_level_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsPricingLevelAsync(
        string pricingLevelId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsPricingLevel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_level_id"] = pricingLevelId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingLevelRead),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/pricing_levels/{pricing_level_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsPricingLevelAsync(
        string pricingLevelId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsPricingLevel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_level_id"] = pricingLevelId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/shipping_profiles</c>.</summary>
    public Task<ApiResponse> CreateSettingsShippingProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsShippingProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingProfileRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/shipping_profiles/{shipping_profile_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingProfileAsync(
        string shippingProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsShippingProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_profile_id"] = shippingProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingProfileRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/shipping_profiles/{shipping_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsShippingProfileAsync(
        string shippingProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsShippingProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_profile_id"] = shippingProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/shipping_profiles/{shipping_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsShippingProfileAsync(
        string shippingProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsShippingProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_profile_id"] = shippingProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/warehouses</c>.</summary>
    public Task<ApiResponse> CreateSettingsWarehouseAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsWarehouses,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWarehouseRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/warehouses/{warehouse_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsWarehouseAsync(
        string warehouseId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsWarehouse,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["warehouse_id"] = warehouseId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWarehouseRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/warehouses/{warehouse_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsWarehouseAsync(
        string warehouseId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsWarehouse,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["warehouse_id"] = warehouseId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWarehouseRead),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/warehouses/{warehouse_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsWarehouseAsync(
        string warehouseId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsWarehouse,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["warehouse_id"] = warehouseId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/taxes</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsTaxAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SettingsUrls.SettingsTaxes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/taxes/{tax_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsTaxAsync(
        string taxId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsUrls.SettingsTax,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["tax_id"] = taxId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTaxRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/taxes/{tax_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsTaxAsync(
        string taxId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SettingsUrls.SettingsTax,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["tax_id"] = taxId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/settings/variations/{variation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsVariationAsync(
        string variationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SettingsUrls.SettingsVariation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["variation_id"] = variationId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Settings.GetCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomObjectsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetCustomObjectsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomObjectAsync(
        ExsitedClient client,
        string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetCustomObjectAsync(
            customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCurrenciesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCurrenciesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCurrenciesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCustomLogicScriptsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomLogicScriptsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCustomLogicScriptsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCustomObjectAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsCustomObjectAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsDiscountProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDiscountProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsDiscountProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsItemGroupsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsItemGroupsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsItemGroupsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsItemGroupAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsItemGroupAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsItemGroupAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPaymentProcessorsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPaymentProcessorsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPaymentProcessorsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPaymentTermsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPaymentTermsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPaymentTermsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPricingLevelsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPricingLevelsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPricingLevelsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsShippingProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsShippingProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsTaxesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTaxesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsTaxesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsTimeZonesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTimeZonesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsTimeZonesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsVariationsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsVariationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsVariationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsVariationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsVariationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsVariationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsWarehousesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsWarehousesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsWarehousesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCurrencyAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCurrencyAsync(
        ExsitedClient client,
        string currencyId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCurrencyAsync(
            currencyId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCustomLogicScriptAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomLogicScriptAsync(
        ExsitedClient client,
        string customLogicScriptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCustomLogicScriptAsync(
            customLogicScriptId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsCustomObjectAsync(
        ExsitedClient client,
        string customObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsCustomObjectAsync(
            customObjectId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCustomObjectAsync(
        ExsitedClient client,
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsCustomObjectAsync(
            customObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsFieldSettingsAccountAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsFieldSettingsAccountAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsFieldSettingsAccountAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsFieldSettingsItemAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsFieldSettingsItemAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsFieldSettingsItemAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsAccountAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsAccountAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsAccountAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsItemAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsItemAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsItemAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsItemGroupAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsItemGroupAsync(
        ExsitedClient client,
        string itemGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsItemGroupAsync(
            itemGroupId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsItemGroupAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsItemGroupAsync(
        ExsitedClient client,
        string itemGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsItemGroupAsync(
            itemGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsItemGroupAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsItemGroupAsync(
        ExsitedClient client,
        string itemGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsItemGroupAsync(
            itemGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsTimeZoneAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTimeZoneAsync(
        ExsitedClient client,
        string timeZoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsTimeZoneAsync(
            timeZoneId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsVariationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsVariationAsync(
        ExsitedClient client,
        string variationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsVariationAsync(
            variationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsVariationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsVariationAsync(
        ExsitedClient client,
        string variationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsVariationAsync(
            variationId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsCustomObjectCustomizeAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCustomObjectCustomizeAsync(
        ExsitedClient client,
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsCustomObjectCustomizeAsync(
            customObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsItemGroupBillingPreferenceAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsItemGroupBillingPreferenceAsync(
        ExsitedClient client,
        string itemGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsItemGroupBillingPreferenceAsync(
            itemGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomObjectsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCustomObjectsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomObjectAsync(
        ExsitedClient client,
        string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsCustomObjectAsync(
            customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> CreateCustomObjectAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateCustomObjectAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> UpdateCustomObjectAsync(
        ExsitedClient client,
        string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateCustomObjectAsync(
            customObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> DeleteCustomObjectAsync(
        ExsitedClient client,
        string customObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteCustomObjectAsync(
            customObjectId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsCurrencyAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCurrencyAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsCurrencyAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsCurrencyAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCurrencyAsync(
        ExsitedClient client,
        string currencyId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsCurrencyAsync(
            currencyId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsCustomLogicScriptAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCustomLogicScriptAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsCustomLogicScriptAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsCustomLogicScriptAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCustomLogicScriptAsync(
        ExsitedClient client,
        string customLogicScriptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsCustomLogicScriptAsync(
            customLogicScriptId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsCustomLogicScriptAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsCustomLogicScriptAsync(
        ExsitedClient client,
        string customLogicScriptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsCustomLogicScriptAsync(
            customLogicScriptId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsDiscountProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsDiscountProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsDiscountProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsDiscountProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDiscountProfileAsync(
        ExsitedClient client,
        string discountProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsDiscountProfileAsync(
            discountProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsDiscountProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsDiscountProfileAsync(
        ExsitedClient client,
        string discountProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsDiscountProfileAsync(
            discountProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsDiscountProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsDiscountProfileAsync(
        ExsitedClient client,
        string discountProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsDiscountProfileAsync(
            discountProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsFieldSettingsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFieldSettingsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsFieldSettingsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsFieldSettingAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFieldSettingAsync(
        ExsitedClient client,
        string fieldSettingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsFieldSettingAsync(
            fieldSettingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsGeneralSettingsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsGeneralSettingsAsync(
        ExsitedClient client,
        string group, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsGeneralSettingsAsync(
            group, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsGeneralSettingAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsGeneralSettingAsync(
        ExsitedClient client,
        string group, string generalSettingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsGeneralSettingAsync(
            group, generalSettingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsDashboardAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsDashboardAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsDashboardAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsDateAndTimeAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsDateAndTimeAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsDateAndTimeAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsDisplayAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsDisplayAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsDisplayAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsGeneralAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsGeneralAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsGeneralAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsLabourAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsLabourAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsLabourAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsOrderAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsOrderAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsOrderAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsPortalAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsPortalAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsPortalAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsPurchaseAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsPurchaseAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsPurchaseAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsSecurityAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsSecurityAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsSecurityAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsGeneralSettingsTransactionAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsGeneralSettingsTransactionAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsGeneralSettingsTransactionAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsPaymentProcessorAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsPaymentProcessorAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsPaymentProcessorAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPaymentProcessorAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPaymentProcessorAsync(
        ExsitedClient client,
        string paymentProcessorId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPaymentProcessorAsync(
            paymentProcessorId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsPaymentProcessorAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsPaymentProcessorAsync(
        ExsitedClient client,
        string paymentProcessorId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsPaymentProcessorAsync(
            paymentProcessorId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsPaymentProcessorAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsPaymentProcessorAsync(
        ExsitedClient client,
        string paymentProcessorId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsPaymentProcessorAsync(
            paymentProcessorId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsPaymentTermAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsPaymentTermAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsPaymentTermAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPaymentTermAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPaymentTermAsync(
        ExsitedClient client,
        string paymentTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPaymentTermAsync(
            paymentTermId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsPaymentTermAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsPaymentTermAsync(
        ExsitedClient client,
        string paymentTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsPaymentTermAsync(
            paymentTermId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsPaymentTermAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsPaymentTermAsync(
        ExsitedClient client,
        string paymentTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsPaymentTermAsync(
            paymentTermId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsPricingLevelAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsPricingLevelAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsPricingLevelAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsPricingLevelAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPricingLevelAsync(
        ExsitedClient client,
        string pricingLevelId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsPricingLevelAsync(
            pricingLevelId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsPricingLevelAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsPricingLevelAsync(
        ExsitedClient client,
        string pricingLevelId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsPricingLevelAsync(
            pricingLevelId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsPricingLevelAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsPricingLevelAsync(
        ExsitedClient client,
        string pricingLevelId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsPricingLevelAsync(
            pricingLevelId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsShippingProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsShippingProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsShippingProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsShippingProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingProfileAsync(
        ExsitedClient client,
        string shippingProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsShippingProfileAsync(
            shippingProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsShippingProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsShippingProfileAsync(
        ExsitedClient client,
        string shippingProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsShippingProfileAsync(
            shippingProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsShippingProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsShippingProfileAsync(
        ExsitedClient client,
        string shippingProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsShippingProfileAsync(
            shippingProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsWarehouseAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsWarehouseAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsWarehouseAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsWarehouseAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsWarehouseAsync(
        ExsitedClient client,
        string warehouseId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsWarehouseAsync(
            warehouseId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsWarehouseAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsWarehouseAsync(
        ExsitedClient client,
        string warehouseId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsWarehouseAsync(
            warehouseId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsWarehouseAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsWarehouseAsync(
        ExsitedClient client,
        string warehouseId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsWarehouseAsync(
            warehouseId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.CreateSettingsTaxAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsTaxAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.CreateSettingsTaxAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.GetSettingsTaxAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTaxAsync(
        ExsitedClient client,
        string taxId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.GetSettingsTaxAsync(
            taxId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.UpdateSettingsTaxAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsTaxAsync(
        ExsitedClient client,
        string taxId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.UpdateSettingsTaxAsync(
            taxId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Settings.DeleteSettingsVariationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsVariationAsync(
        ExsitedClient client,
        string variationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Settings.DeleteSettingsVariationAsync(
            variationId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
