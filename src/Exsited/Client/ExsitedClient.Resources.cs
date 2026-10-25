namespace Exsited.Client;

/// <summary>The resource accessors, one per family, each built on first use; a racing double-build is harmless.</summary>
public sealed partial class ExsitedClient
{
    private Resources.AbaFiles.AbaFiles? _abaFiles;

    /// <summary>The aba files endpoints, built on first use.</summary>
    public Resources.AbaFiles.AbaFiles AbaFiles =>
        _abaFiles ??= new Resources.AbaFiles.AbaFiles(this);

    private Resources.AccountEmails.AccountEmails? _accountEmails;

    /// <summary>The account emails endpoints, built on first use.</summary>
    public Resources.AccountEmails.AccountEmails AccountEmails =>
        _accountEmails ??= new Resources.AccountEmails.AccountEmails(this);

    private Resources.AccountGroups.AccountGroups? _accountGroups;

    /// <summary>The account groups endpoints, built on first use.</summary>
    public Resources.AccountGroups.AccountGroups AccountGroups =>
        _accountGroups ??= new Resources.AccountGroups.AccountGroups(this);

    private Resources.AccountingCodes.AccountingCodes? _accountingCodes;

    /// <summary>The accounting codes endpoints, built on first use.</summary>
    public Resources.AccountingCodes.AccountingCodes AccountingCodes =>
        _accountingCodes ??= new Resources.AccountingCodes.AccountingCodes(this);

    private Resources.Accounts.Accounts? _accounts;

    /// <summary>The accounts endpoints, built on first use.</summary>
    public Resources.Accounts.Accounts Accounts =>
        _accounts ??= new Resources.Accounts.Accounts(this);

    private Resources.ActionScripts.ActionScripts? _actionScripts;

    /// <summary>The action scripts endpoints, built on first use.</summary>
    public Resources.ActionScripts.ActionScripts ActionScripts =>
        _actionScripts ??= new Resources.ActionScripts.ActionScripts(this);

    private Resources.AdditionalCodes.AdditionalCodes? _additionalCodes;

    /// <summary>The additional codes endpoints, built on first use.</summary>
    public Resources.AdditionalCodes.AdditionalCodes AdditionalCodes =>
        _additionalCodes ??= new Resources.AdditionalCodes.AdditionalCodes(this);

    private Resources.AlertResponsibilities.AlertResponsibilities? _alertResponsibilities;

    /// <summary>The alert responsibilities endpoints, built on first use.</summary>
    public Resources.AlertResponsibilities.AlertResponsibilities AlertResponsibilities =>
        _alertResponsibilities ??= new Resources.AlertResponsibilities.AlertResponsibilities(this);

    private Resources.AlertResponsibility.AlertResponsibility? _alertResponsibility;

    /// <summary>The alert responsibility endpoints, built on first use.</summary>
    public Resources.AlertResponsibility.AlertResponsibility AlertResponsibility =>
        _alertResponsibility ??= new Resources.AlertResponsibility.AlertResponsibility(this);

    private Resources.Alerts.Alerts? _alerts;

    /// <summary>The alerts endpoints, built on first use.</summary>
    public Resources.Alerts.Alerts Alerts =>
        _alerts ??= new Resources.Alerts.Alerts(this);

    private Resources.Applications.Applications? _applications;

    /// <summary>The applications endpoints, built on first use.</summary>
    public Resources.Applications.Applications Applications =>
        _applications ??= new Resources.Applications.Applications(this);

    private Resources.ApprovalProfiles.ApprovalProfiles? _approvalProfiles;

    /// <summary>The approval profiles endpoints, built on first use.</summary>
    public Resources.ApprovalProfiles.ApprovalProfiles ApprovalProfiles =>
        _approvalProfiles ??= new Resources.ApprovalProfiles.ApprovalProfiles(this);

    private Resources.ApprovalUserGroups.ApprovalUserGroups? _approvalUserGroups;

    /// <summary>The approval user groups endpoints, built on first use.</summary>
    public Resources.ApprovalUserGroups.ApprovalUserGroups ApprovalUserGroups =>
        _approvalUserGroups ??= new Resources.ApprovalUserGroups.ApprovalUserGroups(this);

    private Resources.Approvals.Approvals? _approvals;

    /// <summary>The approvals endpoints, built on first use.</summary>
    public Resources.Approvals.Approvals Approvals =>
        _approvals ??= new Resources.Approvals.Approvals(this);

    private Resources.AttributeAttachments.AttributeAttachments? _attributeAttachments;

    /// <summary>The attribute attachments endpoints, built on first use.</summary>
    public Resources.AttributeAttachments.AttributeAttachments AttributeAttachments =>
        _attributeAttachments ??= new Resources.AttributeAttachments.AttributeAttachments(this);

    private Resources.BillingPeriods.BillingPeriods? _billingPeriods;

    /// <summary>The billing periods endpoints, built on first use.</summary>
    public Resources.BillingPeriods.BillingPeriods BillingPeriods =>
        _billingPeriods ??= new Resources.BillingPeriods.BillingPeriods(this);

    private Resources.Bookings.Bookings? _bookings;

    /// <summary>The bookings endpoints, built on first use.</summary>
    public Resources.Bookings.Bookings Bookings =>
        _bookings ??= new Resources.Bookings.Bookings(this);

    private Resources.ChargingPeriods.ChargingPeriods? _chargingPeriods;

    /// <summary>The charging periods endpoints, built on first use.</summary>
    public Resources.ChargingPeriods.ChargingPeriods ChargingPeriods =>
        _chargingPeriods ??= new Resources.ChargingPeriods.ChargingPeriods(this);

    private Resources.CommunicationProfiles.CommunicationProfiles? _communicationProfiles;

    /// <summary>The communication profiles endpoints, built on first use.</summary>
    public Resources.CommunicationProfiles.CommunicationProfiles CommunicationProfiles =>
        _communicationProfiles ??= new Resources.CommunicationProfiles.CommunicationProfiles(this);

    private Resources.Communications.Communications? _communications;

    /// <summary>The communications endpoints, built on first use.</summary>
    public Resources.Communications.Communications Communications =>
        _communications ??= new Resources.Communications.Communications(this);

    private Resources.Countries.Countries? _countries;

    /// <summary>The countries endpoints, built on first use.</summary>
    public Resources.Countries.Countries Countries =>
        _countries ??= new Resources.Countries.Countries(this);

    private Resources.CreditNoteApplications.CreditNoteApplications? _creditNoteApplications;

    /// <summary>The credit note applications endpoints, built on first use.</summary>
    public Resources.CreditNoteApplications.CreditNoteApplications CreditNoteApplications =>
        _creditNoteApplications ??= new Resources.CreditNoteApplications.CreditNoteApplications(this);

    private Resources.CreditNotes.CreditNotes? _creditNotes;

    /// <summary>The credit notes endpoints, built on first use.</summary>
    public Resources.CreditNotes.CreditNotes CreditNotes =>
        _creditNotes ??= new Resources.CreditNotes.CreditNotes(this);

    private Resources.CustomAttributes.CustomAttributes? _customAttributes;

    /// <summary>The custom attributes endpoints, built on first use.</summary>
    public Resources.CustomAttributes.CustomAttributes CustomAttributes =>
        _customAttributes ??= new Resources.CustomAttributes.CustomAttributes(this);

    private Resources.CustomComponents.CustomComponents? _customComponents;

    /// <summary>The custom components endpoints, built on first use.</summary>
    public Resources.CustomComponents.CustomComponents CustomComponents =>
        _customComponents ??= new Resources.CustomComponents.CustomComponents(this);

    private Resources.CustomEvents.CustomEvents? _customEvents;

    /// <summary>The custom events endpoints, built on first use.</summary>
    public Resources.CustomEvents.CustomEvents CustomEvents =>
        _customEvents ??= new Resources.CustomEvents.CustomEvents(this);

    private Resources.CustomFeatures.CustomFeatures? _customFeatures;

    /// <summary>The custom features endpoints, built on first use.</summary>
    public Resources.CustomFeatures.CustomFeatures CustomFeatures =>
        _customFeatures ??= new Resources.CustomFeatures.CustomFeatures(this);

    private Resources.CustomFields.CustomFields? _customFields;

    /// <summary>The custom fields endpoints, built on first use.</summary>
    public Resources.CustomFields.CustomFields CustomFields =>
        _customFields ??= new Resources.CustomFields.CustomFields(this);

    private Resources.CustomForms.CustomForms? _customForms;

    /// <summary>The custom forms endpoints, built on first use.</summary>
    public Resources.CustomForms.CustomForms CustomForms =>
        _customForms ??= new Resources.CustomForms.CustomForms(this);

    private Resources.DayOfMonth.DayOfMonth? _dayOfMonth;

    /// <summary>The day of month endpoints, built on first use.</summary>
    public Resources.DayOfMonth.DayOfMonth DayOfMonth =>
        _dayOfMonth ??= new Resources.DayOfMonth.DayOfMonth(this);

    private Resources.Departments.Departments? _departments;

    /// <summary>The departments endpoints, built on first use.</summary>
    public Resources.Departments.Departments Departments =>
        _departments ??= new Resources.Departments.Departments(this);

    private Resources.Designations.Designations? _designations;

    /// <summary>The designations endpoints, built on first use.</summary>
    public Resources.Designations.Designations Designations =>
        _designations ??= new Resources.Designations.Designations(this);

    private Resources.DocumentTemplates.DocumentTemplates? _documentTemplates;

    /// <summary>The document templates endpoints, built on first use.</summary>
    public Resources.DocumentTemplates.DocumentTemplates DocumentTemplates =>
        _documentTemplates ??= new Resources.DocumentTemplates.DocumentTemplates(this);

    private Resources.EmailTemplates.EmailTemplates? _emailTemplates;

    /// <summary>The email templates endpoints, built on first use.</summary>
    public Resources.EmailTemplates.EmailTemplates EmailTemplates =>
        _emailTemplates ??= new Resources.EmailTemplates.EmailTemplates(this);

    private Resources.Employees.Employees? _employees;

    /// <summary>The employees endpoints, built on first use.</summary>
    public Resources.Employees.Employees Employees =>
        _employees ??= new Resources.Employees.Employees(this);

    private Resources.Events.Events? _events;

    /// <summary>The events endpoints, built on first use.</summary>
    public Resources.Events.Events Events =>
        _events ??= new Resources.Events.Events(this);

    private Resources.Express.Express? _express;

    /// <summary>The express endpoints, built on first use.</summary>
    public Resources.Express.Express Express =>
        _express ??= new Resources.Express.Express(this);

    private Resources.ExternalDatabases.ExternalDatabases? _externalDatabases;

    /// <summary>The external databases endpoints, built on first use.</summary>
    public Resources.ExternalDatabases.ExternalDatabases ExternalDatabases =>
        _externalDatabases ??= new Resources.ExternalDatabases.ExternalDatabases(this);

    private Resources.FulfillmentProfiles.FulfillmentProfiles? _fulfillmentProfiles;

    /// <summary>The fulfillment profiles endpoints, built on first use.</summary>
    public Resources.FulfillmentProfiles.FulfillmentProfiles FulfillmentProfiles =>
        _fulfillmentProfiles ??= new Resources.FulfillmentProfiles.FulfillmentProfiles(this);

    private Resources.FulfillmentTerms.FulfillmentTerms? _fulfillmentTerms;

    /// <summary>The fulfillment terms endpoints, built on first use.</summary>
    public Resources.FulfillmentTerms.FulfillmentTerms FulfillmentTerms =>
        _fulfillmentTerms ??= new Resources.FulfillmentTerms.FulfillmentTerms(this);

    private Resources.GiftCertificates.GiftCertificates? _giftCertificates;

    /// <summary>The gift certificates endpoints, built on first use.</summary>
    public Resources.GiftCertificates.GiftCertificates GiftCertificates =>
        _giftCertificates ??= new Resources.GiftCertificates.GiftCertificates(this);

    private Resources.IntegrationConnections.IntegrationConnections? _integrationConnections;

    /// <summary>The integration connections endpoints, built on first use.</summary>
    public Resources.IntegrationConnections.IntegrationConnections IntegrationConnections =>
        _integrationConnections ??= new Resources.IntegrationConnections.IntegrationConnections(this);

    private Resources.InventoryAdjustments.InventoryAdjustments? _inventoryAdjustments;

    /// <summary>The inventory adjustments endpoints, built on first use.</summary>
    public Resources.InventoryAdjustments.InventoryAdjustments InventoryAdjustments =>
        _inventoryAdjustments ??= new Resources.InventoryAdjustments.InventoryAdjustments(this);

    private Resources.InvoiceTerms.InvoiceTerms? _invoiceTerms;

    /// <summary>The invoice terms endpoints, built on first use.</summary>
    public Resources.InvoiceTerms.InvoiceTerms InvoiceTerms =>
        _invoiceTerms ??= new Resources.InvoiceTerms.InvoiceTerms(this);

    private Resources.Invoices.Invoices? _invoices;

    /// <summary>The invoices endpoints, built on first use.</summary>
    public Resources.Invoices.Invoices Invoices =>
        _invoices ??= new Resources.Invoices.Invoices(this);

    private Resources.ItemFulfillments.ItemFulfillments? _itemFulfillments;

    /// <summary>The item fulfillments endpoints, built on first use.</summary>
    public Resources.ItemFulfillments.ItemFulfillments ItemFulfillments =>
        _itemFulfillments ??= new Resources.ItemFulfillments.ItemFulfillments(this);

    private Resources.ItemReceipts.ItemReceipts? _itemReceipts;

    /// <summary>The item receipts endpoints, built on first use.</summary>
    public Resources.ItemReceipts.ItemReceipts ItemReceipts =>
        _itemReceipts ??= new Resources.ItemReceipts.ItemReceipts(this);

    private Resources.Items.Items? _items;

    /// <summary>The items endpoints, built on first use.</summary>
    public Resources.Items.Items Items =>
        _items ??= new Resources.Items.Items(this);

    private Resources.Labours.Labours? _labours;

    /// <summary>The labours endpoints, built on first use.</summary>
    public Resources.Labours.Labours Labours =>
        _labours ??= new Resources.Labours.Labours(this);

    private Resources.Milestones.Milestones? _milestones;

    /// <summary>The milestones endpoints, built on first use.</summary>
    public Resources.Milestones.Milestones Milestones =>
        _milestones ??= new Resources.Milestones.Milestones(this);

    private Resources.NoteAttachments.NoteAttachments? _noteAttachments;

    /// <summary>The note attachments endpoints, built on first use.</summary>
    public Resources.NoteAttachments.NoteAttachments NoteAttachments =>
        _noteAttachments ??= new Resources.NoteAttachments.NoteAttachments(this);

    private Resources.NoteGroups.NoteGroups? _noteGroups;

    /// <summary>The note groups endpoints, built on first use.</summary>
    public Resources.NoteGroups.NoteGroups NoteGroups =>
        _noteGroups ??= new Resources.NoteGroups.NoteGroups(this);

    private Resources.Orders.Orders? _orders;

    /// <summary>The orders endpoints, built on first use.</summary>
    public Resources.Orders.Orders Orders =>
        _orders ??= new Resources.Orders.Orders(this);

    private Resources.Organisation.Organisation? _organisation;

    /// <summary>The organisation endpoints, built on first use.</summary>
    public Resources.Organisation.Organisation Organisation =>
        _organisation ??= new Resources.Organisation.Organisation(this);

    private Resources.Organisations.Organisations? _organisations;

    /// <summary>The organisations endpoints, built on first use.</summary>
    public Resources.Organisations.Organisations Organisations =>
        _organisations ??= new Resources.Organisations.Organisations(this);

    private Resources.Payments.Payments? _payments;

    /// <summary>The payments endpoints, built on first use.</summary>
    public Resources.Payments.Payments Payments =>
        _payments ??= new Resources.Payments.Payments(this);

    private Resources.Portals.Portals? _portals;

    /// <summary>The portals endpoints, built on first use.</summary>
    public Resources.Portals.Portals Portals =>
        _portals ??= new Resources.Portals.Portals(this);

    private Resources.PricingPeriods.PricingPeriods? _pricingPeriods;

    /// <summary>The pricing periods endpoints, built on first use.</summary>
    public Resources.PricingPeriods.PricingPeriods PricingPeriods =>
        _pricingPeriods ??= new Resources.PricingPeriods.PricingPeriods(this);

    private Resources.ProformaInvoices.ProformaInvoices? _proformaInvoices;

    /// <summary>The proforma invoices endpoints, built on first use.</summary>
    public Resources.ProformaInvoices.ProformaInvoices ProformaInvoices =>
        _proformaInvoices ??= new Resources.ProformaInvoices.ProformaInvoices(this);

    private Resources.PurchaseCreditNoteApplications.PurchaseCreditNoteApplications? _purchaseCreditNoteApplications;

    /// <summary>The purchase credit note applications endpoints, built on first use.</summary>
    public Resources.PurchaseCreditNoteApplications.PurchaseCreditNoteApplications PurchaseCreditNoteApplications =>
        _purchaseCreditNoteApplications ??= new Resources.PurchaseCreditNoteApplications.PurchaseCreditNoteApplications(this);

    private Resources.PurchaseCreditNotes.PurchaseCreditNotes? _purchaseCreditNotes;

    /// <summary>The purchase credit notes endpoints, built on first use.</summary>
    public Resources.PurchaseCreditNotes.PurchaseCreditNotes PurchaseCreditNotes =>
        _purchaseCreditNotes ??= new Resources.PurchaseCreditNotes.PurchaseCreditNotes(this);

    private Resources.PurchaseExpress.PurchaseExpress? _purchaseExpress;

    /// <summary>The purchase express endpoints, built on first use.</summary>
    public Resources.PurchaseExpress.PurchaseExpress PurchaseExpress =>
        _purchaseExpress ??= new Resources.PurchaseExpress.PurchaseExpress(this);

    private Resources.PurchaseInvoices.PurchaseInvoices? _purchaseInvoices;

    /// <summary>The purchase invoices endpoints, built on first use.</summary>
    public Resources.PurchaseInvoices.PurchaseInvoices PurchaseInvoices =>
        _purchaseInvoices ??= new Resources.PurchaseInvoices.PurchaseInvoices(this);

    private Resources.PurchaseOrders.PurchaseOrders? _purchaseOrders;

    /// <summary>The purchase orders endpoints, built on first use.</summary>
    public Resources.PurchaseOrders.PurchaseOrders PurchaseOrders =>
        _purchaseOrders ??= new Resources.PurchaseOrders.PurchaseOrders(this);

    private Resources.PurchasePayments.PurchasePayments? _purchasePayments;

    /// <summary>The purchase payments endpoints, built on first use.</summary>
    public Resources.PurchasePayments.PurchasePayments PurchasePayments =>
        _purchasePayments ??= new Resources.PurchasePayments.PurchasePayments(this);

    private Resources.PurchaseRefunds.PurchaseRefunds? _purchaseRefunds;

    /// <summary>The purchase refunds endpoints, built on first use.</summary>
    public Resources.PurchaseRefunds.PurchaseRefunds PurchaseRefunds =>
        _purchaseRefunds ??= new Resources.PurchaseRefunds.PurchaseRefunds(this);

    private Resources.QuoteOrders.QuoteOrders? _quoteOrders;

    /// <summary>The quote orders endpoints, built on first use.</summary>
    public Resources.QuoteOrders.QuoteOrders QuoteOrders =>
        _quoteOrders ??= new Resources.QuoteOrders.QuoteOrders(this);

    private Resources.ReceiveTerms.ReceiveTerms? _receiveTerms;

    /// <summary>The receive terms endpoints, built on first use.</summary>
    public Resources.ReceiveTerms.ReceiveTerms ReceiveTerms =>
        _receiveTerms ??= new Resources.ReceiveTerms.ReceiveTerms(this);

    private Resources.Reconciliations.Reconciliations? _reconciliations;

    /// <summary>The reconciliations endpoints, built on first use.</summary>
    public Resources.Reconciliations.Reconciliations Reconciliations =>
        _reconciliations ??= new Resources.Reconciliations.Reconciliations(this);

    private Resources.Refunds.Refunds? _refunds;

    /// <summary>The refunds endpoints, built on first use.</summary>
    public Resources.Refunds.Refunds Refunds =>
        _refunds ??= new Resources.Refunds.Refunds(this);

    private Resources.RentalAssets.RentalAssets? _rentalAssets;

    /// <summary>The rental assets endpoints, built on first use.</summary>
    public Resources.RentalAssets.RentalAssets RentalAssets =>
        _rentalAssets ??= new Resources.RentalAssets.RentalAssets(this);

    private Resources.Reports.Reports? _reports;

    /// <summary>The reports endpoints, built on first use.</summary>
    public Resources.Reports.Reports Reports =>
        _reports ??= new Resources.Reports.Reports(this);

    private Resources.ReturnMerchandiseAuthorisations.ReturnMerchandiseAuthorisations? _returnMerchandiseAuthorisations;

    /// <summary>The return merchandise authorisations endpoints, built on first use.</summary>
    public Resources.ReturnMerchandiseAuthorisations.ReturnMerchandiseAuthorisations ReturnMerchandiseAuthorisations =>
        _returnMerchandiseAuthorisations ??= new Resources.ReturnMerchandiseAuthorisations.ReturnMerchandiseAuthorisations(this);

    private Resources.ReturnVendorAuthorizations.ReturnVendorAuthorizations? _returnVendorAuthorizations;

    /// <summary>The return vendor authorizations endpoints, built on first use.</summary>
    public Resources.ReturnVendorAuthorizations.ReturnVendorAuthorizations ReturnVendorAuthorizations =>
        _returnVendorAuthorizations ??= new Resources.ReturnVendorAuthorizations.ReturnVendorAuthorizations(this);

    private Resources.Roles.Roles? _roles;

    /// <summary>The roles endpoints, built on first use.</summary>
    public Resources.Roles.Roles Roles =>
        _roles ??= new Resources.Roles.Roles(this);

    private Resources.SalesReps.SalesReps? _salesReps;

    /// <summary>The sales reps endpoints, built on first use.</summary>
    public Resources.SalesReps.SalesReps SalesReps =>
        _salesReps ??= new Resources.SalesReps.SalesReps(this);

    private Resources.Salutations.Salutations? _salutations;

    /// <summary>The salutations endpoints, built on first use.</summary>
    public Resources.Salutations.Salutations Salutations =>
        _salutations ??= new Resources.Salutations.Salutations(this);

    private Resources.Settings.Settings? _settings;

    /// <summary>The settings endpoints, built on first use.</summary>
    public Resources.Settings.Settings Settings =>
        _settings ??= new Resources.Settings.Settings(this);

    private Resources.SettingsWorkflows.SettingsWorkflows? _settingsWorkflows;

    /// <summary>The settings workflows endpoints, built on first use.</summary>
    public Resources.SettingsWorkflows.SettingsWorkflows SettingsWorkflows =>
        _settingsWorkflows ??= new Resources.SettingsWorkflows.SettingsWorkflows(this);

    private Resources.ShippingPackages.ShippingPackages? _shippingPackages;

    /// <summary>The shipping packages endpoints, built on first use.</summary>
    public Resources.ShippingPackages.ShippingPackages ShippingPackages =>
        _shippingPackages ??= new Resources.ShippingPackages.ShippingPackages(this);

    private Resources.ShippingRules.ShippingRules? _shippingRules;

    /// <summary>The shipping rules endpoints, built on first use.</summary>
    public Resources.ShippingRules.ShippingRules ShippingRules =>
        _shippingRules ??= new Resources.ShippingRules.ShippingRules(this);

    private Resources.SystemEvents.SystemEvents? _systemEvents;

    /// <summary>The system events endpoints, built on first use.</summary>
    public Resources.SystemEvents.SystemEvents SystemEvents =>
        _systemEvents ??= new Resources.SystemEvents.SystemEvents(this);

    private Resources.Tasks.Tasks? _tasks;

    /// <summary>The tasks endpoints, built on first use.</summary>
    public Resources.Tasks.Tasks Tasks =>
        _tasks ??= new Resources.Tasks.Tasks(this);

    private Resources.Teams.Teams? _teams;

    /// <summary>The teams endpoints, built on first use.</summary>
    public Resources.Teams.Teams Teams =>
        _teams ??= new Resources.Teams.Teams(this);

    private Resources.TimePeriods.TimePeriods? _timePeriods;

    /// <summary>The time periods endpoints, built on first use.</summary>
    public Resources.TimePeriods.TimePeriods TimePeriods =>
        _timePeriods ??= new Resources.TimePeriods.TimePeriods(this);

    private Resources.Timesheets.Timesheets? _timesheets;

    /// <summary>The timesheets endpoints, built on first use.</summary>
    public Resources.Timesheets.Timesheets Timesheets =>
        _timesheets ??= new Resources.Timesheets.Timesheets(this);

    private Resources.Uom.Uom? _uom;

    /// <summary>The uom endpoints, built on first use.</summary>
    public Resources.Uom.Uom Uom =>
        _uom ??= new Resources.Uom.Uom(this);

    private Resources.Usages.Usages? _usages;

    /// <summary>The usages endpoints, built on first use.</summary>
    public Resources.Usages.Usages Usages =>
        _usages ??= new Resources.Usages.Usages(this);

    private Resources.Webhooks.Webhooks? _webhooks;

    /// <summary>The webhooks endpoints, built on first use.</summary>
    public Resources.Webhooks.Webhooks Webhooks =>
        _webhooks ??= new Resources.Webhooks.Webhooks(this);

    private Resources.Workflows.Workflows? _workflows;

    /// <summary>The workflows endpoints, built on first use.</summary>
    public Resources.Workflows.Workflows Workflows =>
        _workflows ??= new Resources.Workflows.Workflows(this);
    private Resources.Zones.Zones? _zones;

    /// <summary>The zones endpoints, built on first use.</summary>
    public Resources.Zones.Zones Zones =>
        _zones ??= new Resources.Zones.Zones(this);


}
