using Exsited.Errors;

namespace Exsited.Client;

/// <summary>Reaching an endpoint group by its registered name; explicit, so a typo raises.</summary>
public static class ResourceBinding
{
    private static readonly object Gate = new();

    private static readonly Dictionary<string, Func<ExsitedClient, object>> Modules =
        new(StringComparer.Ordinal)
        {
            // The client's cached group, so both routes hand back the same object.
            ["aba_files"] = client => client.AbaFiles,
            ["account_emails"] = client => client.AccountEmails,
            ["account_groups"] = client => client.AccountGroups,
            ["accounting_codes"] = client => client.AccountingCodes,
            ["accounts"] = client => client.Accounts,
            ["action_scripts"] = client => client.ActionScripts,
            ["additional_codes"] = client => client.AdditionalCodes,
            ["alert_responsibilities"] = client => client.AlertResponsibilities,
            ["alert_responsibility"] = client => client.AlertResponsibility,
            ["alerts"] = client => client.Alerts,
            ["applications"] = client => client.Applications,
            ["approval_profiles"] = client => client.ApprovalProfiles,
            ["approval_user_groups"] = client => client.ApprovalUserGroups,
            ["approvals"] = client => client.Approvals,
            ["attribute_attachments"] = client => client.AttributeAttachments,
            ["billing_periods"] = client => client.BillingPeriods,
            ["bookings"] = client => client.Bookings,
            ["charging_periods"] = client => client.ChargingPeriods,
            ["communication_profiles"] = client => client.CommunicationProfiles,
            ["communications"] = client => client.Communications,
            ["countries"] = client => client.Countries,
            ["credit_note_applications"] = client => client.CreditNoteApplications,
            ["credit_notes"] = client => client.CreditNotes,
            ["custom_attributes"] = client => client.CustomAttributes,
            ["custom_components"] = client => client.CustomComponents,
            ["custom_events"] = client => client.CustomEvents,
            ["custom_features"] = client => client.CustomFeatures,
            ["custom_fields"] = client => client.CustomFields,
            ["custom_forms"] = client => client.CustomForms,
            ["day_of_month"] = client => client.DayOfMonth,
            ["departments"] = client => client.Departments,
            ["designations"] = client => client.Designations,
            ["document_templates"] = client => client.DocumentTemplates,
            ["email_templates"] = client => client.EmailTemplates,
            ["employees"] = client => client.Employees,
            ["events"] = client => client.Events,
            ["express"] = client => client.Express,
            ["external_databases"] = client => client.ExternalDatabases,
            ["fulfillment_profiles"] = client => client.FulfillmentProfiles,
            ["fulfillment_terms"] = client => client.FulfillmentTerms,
            ["gift_certificates"] = client => client.GiftCertificates,
            ["integration_connections"] = client => client.IntegrationConnections,
            ["inventory_adjustments"] = client => client.InventoryAdjustments,
            ["invoice_terms"] = client => client.InvoiceTerms,
            ["invoices"] = client => client.Invoices,
            ["item_fulfillments"] = client => client.ItemFulfillments,
            ["item_receipts"] = client => client.ItemReceipts,
            ["items"] = client => client.Items,
            ["labours"] = client => client.Labours,
            ["milestones"] = client => client.Milestones,
            ["note_attachments"] = client => client.NoteAttachments,
            ["note_groups"] = client => client.NoteGroups,
            ["orders"] = client => client.Orders,
            ["organisation"] = client => client.Organisation,
            ["organisations"] = client => client.Organisations,
            ["payments"] = client => client.Payments,
            ["portals"] = client => client.Portals,
            ["pricing_periods"] = client => client.PricingPeriods,
            ["proforma_invoices"] = client => client.ProformaInvoices,
            ["purchase_credit_note_applications"] = client => client.PurchaseCreditNoteApplications,
            ["purchase_credit_notes"] = client => client.PurchaseCreditNotes,
            ["purchase_express"] = client => client.PurchaseExpress,
            ["purchase_invoices"] = client => client.PurchaseInvoices,
            ["purchase_orders"] = client => client.PurchaseOrders,
            ["purchase_payments"] = client => client.PurchasePayments,
            ["purchase_refunds"] = client => client.PurchaseRefunds,
            ["quote_orders"] = client => client.QuoteOrders,
            ["receive_terms"] = client => client.ReceiveTerms,
            ["reconciliations"] = client => client.Reconciliations,
            ["refunds"] = client => client.Refunds,
            ["rental_assets"] = client => client.RentalAssets,
            ["reports"] = client => client.Reports,
            ["return_merchandise_authorisations"] = client => client.ReturnMerchandiseAuthorisations,
            ["return_vendor_authorizations"] = client => client.ReturnVendorAuthorizations,
            ["roles"] = client => client.Roles,
            ["sales_reps"] = client => client.SalesReps,
            ["salutations"] = client => client.Salutations,
            ["settings"] = client => client.Settings,
            ["settings_workflows"] = client => client.SettingsWorkflows,
            ["shipping_packages"] = client => client.ShippingPackages,
            ["shipping_rules"] = client => client.ShippingRules,
            ["system_events"] = client => client.SystemEvents,
            ["tasks"] = client => client.Tasks,
            ["teams"] = client => client.Teams,
            ["time_periods"] = client => client.TimePeriods,
            ["timesheets"] = client => client.Timesheets,
            ["uom"] = client => client.Uom,
            ["usages"] = client => client.Usages,
            ["webhooks"] = client => client.Webhooks,
            ["workflows"] = client => client.Workflows,
            ["zones"] = client => client.Zones,
        };

    /// <summary>Register a resource factory under a lower snake_case name, refusing any collision.</summary>
    public static void RegisterResourceModule(
        string resourceName, Func<ExsitedClient, object> factory)
    {
        if (string.IsNullOrEmpty(resourceName) || resourceName[0] == '_'
            || !resourceName.All(character =>
                character is >= 'a' and <= 'z' or >= '0' and <= '9' or '_'))
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"cannot register resource '{resourceName}': a resource name must be lower "
                + "snake_case and must not start with an underscore - that is the "
                + "vocabulary the resource list is written in"));

        if (ClientMemberNames.Contains(Normalise(resourceName)))
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"cannot register resource '{resourceName}': ExsitedClient already "
                + "carries a member of that name, so a caller reaching for the group "
                + "would get the member instead - pick another name"));

        ArgumentNullException.ThrowIfNull(factory);

        lock (Gate)
        {
            if (Modules.TryGetValue(resourceName, out var registered) && registered != factory)
                // The same delegate is idempotent; a different one would give one name two groups.
                throw new SdkUsageError(Redaction.RedactMessageText(
                    $"cannot register resource '{resourceName}': it is already registered "
                    + "against a different factory, and a client that resolved the old one "
                    + "keeps it - pick another name"));
            Modules[resourceName] = factory;
        }
    }

    /// <summary>Every registered resource name, ordinally sorted.</summary>
    public static IReadOnlyList<string> RegisteredResourceNames()
    {
        lock (Gate)
            return Modules.Keys.OrderBy(name => name, StringComparer.Ordinal).ToList();
    }

    /// <summary>The factory registered under a name, never <c>null</c>.</summary>
    public static Func<ExsitedClient, object> ResolveResourceModule(string resourceName)
    {
        lock (Gate)
        {
            if (Modules.TryGetValue(resourceName, out var factory))
                return factory;
            var registered = string.Join(", ",
                Modules.Keys.OrderBy(name => name, StringComparer.Ordinal));
            throw new SdkAttributeError(Redaction.RedactMessageText(
                $"no resource named '{resourceName}'; registered: {registered}"));
        }
    }

    // By reflection, so a member added to the client joins this check by itself.
    private static readonly HashSet<string> ClientMemberNames =
        typeof(ExsitedClient)
            .GetMembers()
            .Select(member => Normalise(member.Name))
            .ToHashSet(StringComparer.Ordinal);

    // Strip underscores and case, so account_emails meets AccountEmails.
    private static string Normalise(string name) =>
        name.Replace("_", string.Empty, StringComparison.Ordinal).ToLowerInvariant();
}
