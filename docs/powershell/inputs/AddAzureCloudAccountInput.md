### AddAzureCloudAccountInput
Input for adding an Azure Cloud Account.

- sessionId: System.String
  - Session ID of the current OAuth session.
- tenantDomainName: System.String
  - Domain name of the Azure Tenant.
- subscriptions: list of AddAzureCloudAccountSubscriptionInputs
  - Subscriptions to be added to the Azure Cloud Account.
- regions: list of AzureCloudAccountRegions
  - Regions to be added to the Azure Cloud Account.
