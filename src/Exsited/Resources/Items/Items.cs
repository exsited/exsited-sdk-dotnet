using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Items.ItemsDto;

namespace Exsited.Resources.Items;

/// <summary>The v4 items endpoints, as a typed resource bound to one client.</summary>
public sealed class Items : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Items</c>.</summary>
    public Items(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/items</c>.</summary>
    public Task<ApiResponse> GetItemsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.Items,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/items</c>.</summary>
    public Task<ApiResponse> CreateItemAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.Items,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemsView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/items/{item_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemAsync(
        string itemId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemsUrls.Item,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}</c>.</summary>
    public Task<ApiResponse> GetItemAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.Item,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/bundle_details</c>.</summary>
    public Task<ApiResponse> UpdateItemBundleDetailsAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemBundleDetails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemBundleDetails),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/deactivate</c>. The API needs no body:
    /// <paramref name="payload"/> is optional, and with <c>null</c> the request is sent without one.</summary>
    public Task<ApiResponse> DeactivateItemAsync(
        string itemId, object? payload = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(ItemsUrls.ItemDeactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemDeactivate),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/family_details</c>.</summary>
    public Task<ApiResponse> GetItemFamilyDetailsAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemFamilyDetails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFamilyDetails),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/items/{item_id}/family_details</c>.</summary>
    public Task<ApiResponse> CreateItemFamilyDetailAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemFamilyDetails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFamilyDetails),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/image</c>.</summary>
    public Task<ApiResponse> ImageItemAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemImage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemImage),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/information</c>.</summary>
    public Task<ApiResponse> UpdateItemInformationAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSale),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/items/{item_id}/information</c>.</summary>
    public Task<ApiResponse> GetItemInformationAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemInformation),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/inventories</c>.</summary>
    public Task<ApiResponse> GetItemInventoriesAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemInventories,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemInventories),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/inventories</c>.</summary>
    public Task<ApiResponse> UpdateItemInventoriesAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemInventories,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSale),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/items/{item_id}/inventory_adjustments</c>.</summary>
    public Task<ApiResponse> GetItemInventoryAdjustmentsAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemInventoryAdjustments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemInventoryAdjustmentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/notes</c>.</summary>
    public Task<ApiResponse> GetItemNotesAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/items/{item_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateItemNoteAsync(
        string itemId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(ItemsUrls.ItemNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNote),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/items/{item_id}/package_details</c>.</summary>
    public Task<ApiResponse> GetItemPackageDetailsAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemPackageDetails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemPackageDetails),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/items/{item_id}/package_details</c>.</summary>
    public Task<ApiResponse> CreateItemPackageDetailAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemPackageDetails,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemPackageDetails),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/items/{item_id}/purchase</c>.</summary>
    public Task<ApiResponse> GetItemPurchaseAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemPurchase,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemPurchase),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/purchase</c>.</summary>
    public Task<ApiResponse> UpdateItemPurchaseAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemPurchase,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSale),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/purchase</c>.</summary>
    public Task<ApiResponse> CreateItemPurchaseAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemPurchase,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemPurchaseCreated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/reactivate</c>. The API needs no body:
    /// <paramref name="payload"/> is optional, and with <c>null</c> the request is sent without one.</summary>
    public Task<ApiResponse> ReactivateItemAsync(
        string itemId, object? payload = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(ItemsUrls.ItemReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemReactivate),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/sale</c>.</summary>
    public Task<ApiResponse> GetItemSaleAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemSale,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSaleRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/sale</c>.</summary>
    public Task<ApiResponse> UpdateItemSaleAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemSale,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSale),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/sale</c>.</summary>
    public Task<ApiResponse> CreateItemSaleAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemSale,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemSaleCreated),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/variations</c>.</summary>
    public Task<ApiResponse> UpdateItemVariationsAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemVariations,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemVariations),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/inventory/add</c>.</summary>
    public Task<ApiResponse> CreateItemInventoryAddAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemInventoryAdd,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemInventoryAdd),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/items/{item_id}/notes/{item_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemNoteAsync(
        string itemId, string itemNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemsUrls.ItemNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = itemNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/notes/{item_note_id}</c>.</summary>
    public Task<ApiResponse> GetItemNoteAsync(
        string itemId, string itemNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = itemNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNote),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/notes/{item_note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdateItemNoteAsync(
        string itemId, string itemNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = itemNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/items/{item_id}/package_details/{package_detail_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemPackageDetailAsync(
        string itemId, string packageDetailId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemsUrls.ItemPackageDetail,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["package_detail_id"] = packageDetailId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/package_details/{package_detail_id}</c>.</summary>
    public Task<ApiResponse> GetItemPackageDetailAsync(
        string itemId, string packageDetailId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemPackageDetail,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["package_detail_id"] = packageDetailId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemPackageDetail),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files</c>.</summary>
    public Task<ApiResponse> GetItemNoteFilesAsync(
        string itemId, string itemNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = itemNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/warehouses/{warehouse_name}/inventories</c>.</summary>
    public Task<ApiResponse> GetItemWarehouseInventoriesAsync(
        string itemId, string warehouseName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemWarehouseInventories,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["warehouse_name"] = warehouseName },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemWarehouseInventories),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files/{item_file_id}</c>.</summary>
    public Task<ApiResponse> GetItemNoteFileAsync(
        string itemId, string itemNoteId, string itemFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = itemNoteId, ["item_file_id"] = itemFileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemNoteFile),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/items/{item_id}/inventories</c>.</summary>
    public Task<ApiResponse> CreateItemInventoriesAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemInventories,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Item),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/inventory</c>.</summary>
    public Task<ApiResponse> CreateItemInventoryAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemInventory,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Item),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/items/{item_id}/inventories/add</c>.</summary>
    public Task<ApiResponse> AddItemInventoriesAsync(
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemsUrls.ItemInventoriesAdd,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Item),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/items/{item_id}/package_details/{package_detail_id}</c>.</summary>
    public Task<ApiResponse> UpdateItemPackageDetailAsync(
        string itemId, string packageDetailId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemsUrls.ItemPackageDetail,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["package_detail_id"] = packageDetailId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Item),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/items/{item_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemNoteFileAsync(
        string itemId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemsUrls.ItemNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId, ["item_note_id"] = noteId, ["item_file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/items/{item_id}/kpis</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetItemKpisAsync(
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemsUrls.ItemKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_id"] = itemId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Items.GetItemsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.DeleteItemAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemAsync(
        ExsitedClient client,
        string itemId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.DeleteItemAsync(
            itemId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemAsync</c>.</summary>
    public static Task<ApiResponse> GetItemAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemBundleDetailsAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemBundleDetailsAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemBundleDetailsAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.DeactivateItemAsync</c>.</summary>
    public static Task<ApiResponse> DeactivateItemAsync(
        ExsitedClient client,
        string itemId, object? payload = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.DeactivateItemAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemFamilyDetailsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemFamilyDetailsAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemFamilyDetailsAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemFamilyDetailAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemFamilyDetailAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemFamilyDetailAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.ImageItemAsync</c>.</summary>
    public static Task<ApiResponse> ImageItemAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.ImageItemAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemInformationAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemInformationAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetItemInformationAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemInformationAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> GetItemInventoriesAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemInventoriesAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemInventoriesAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemInventoriesAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemInventoryAdjustmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemInventoryAdjustmentsAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemInventoryAdjustmentsAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetItemNotesAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemNotesAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemNoteAsync(
        ExsitedClient client,
        string itemId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemNoteAsync(
            itemId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemPackageDetailsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemPackageDetailsAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemPackageDetailsAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemPackageDetailAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemPackageDetailAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemPackageDetailAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemPurchaseAsync</c>.</summary>
    public static Task<ApiResponse> GetItemPurchaseAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemPurchaseAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemPurchaseAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemPurchaseAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemPurchaseAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemPurchaseAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemPurchaseAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemPurchaseAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.ReactivateItemAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateItemAsync(
        ExsitedClient client,
        string itemId, object? payload = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.ReactivateItemAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemSaleAsync</c>.</summary>
    public static Task<ApiResponse> GetItemSaleAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemSaleAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemSaleAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemSaleAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemSaleAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemSaleAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemSaleAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemSaleAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemVariationsAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemVariationsAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemVariationsAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemInventoryAddAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemInventoryAddAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemInventoryAddAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.DeleteItemNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemNoteAsync(
        ExsitedClient client,
        string itemId, string itemNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.DeleteItemNoteAsync(
            itemId, itemNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetItemNoteAsync(
        ExsitedClient client,
        string itemId, string itemNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemNoteAsync(
            itemId, itemNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemNoteAsync(
        ExsitedClient client,
        string itemId, string itemNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemNoteAsync(
            itemId, itemNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.DeleteItemPackageDetailAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemPackageDetailAsync(
        ExsitedClient client,
        string itemId, string packageDetailId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.DeleteItemPackageDetailAsync(
            itemId, packageDetailId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemPackageDetailAsync</c>.</summary>
    public static Task<ApiResponse> GetItemPackageDetailAsync(
        ExsitedClient client,
        string itemId, string packageDetailId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemPackageDetailAsync(
            itemId, packageDetailId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetItemNoteFilesAsync(
        ExsitedClient client,
        string itemId, string itemNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemNoteFilesAsync(
            itemId, itemNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemWarehouseInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> GetItemWarehouseInventoriesAsync(
        ExsitedClient client,
        string itemId, string warehouseName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemWarehouseInventoriesAsync(
            itemId, warehouseName, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetItemNoteFileAsync(
        ExsitedClient client,
        string itemId, string itemNoteId, string itemFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemNoteFileAsync(
            itemId, itemNoteId, itemFileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Items.CreateItemInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemInventoriesAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemInventoriesAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.CreateItemInventoryAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemInventoryAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.CreateItemInventoryAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.AddItemInventoriesAsync</c>.</summary>
    public static Task<ApiResponse> AddItemInventoriesAsync(
        ExsitedClient client,
        string itemId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.AddItemInventoriesAsync(
            itemId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.UpdateItemPackageDetailAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemPackageDetailAsync(
        ExsitedClient client,
        string itemId, string packageDetailId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.UpdateItemPackageDetailAsync(
            itemId, packageDetailId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.DeleteItemNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemNoteFileAsync(
        ExsitedClient client,
        string itemId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.DeleteItemNoteFileAsync(
            itemId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Items.GetItemKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetItemKpisAsync(
        ExsitedClient client,
        string itemId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Items.GetItemKpisAsync(
            itemId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
