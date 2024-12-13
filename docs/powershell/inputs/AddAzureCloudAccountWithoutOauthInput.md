### AddAzureCloudAccountWithoutOauthInput
Input for adding an Azure Cloud Account without OAuth.

- tenantDomainName: System.String
  - Domain Name of the Azure tenant.
- subscriptions: list of AddAzureCloudAccountSubscriptionInputWithoutOauths
  - Subscriptions to be added to the Azure Cloud Account.
- regions: list of AzureCloudAccountRegions
  - Regions to be added to the Azure Cloud Account.
- isAsynchronous: System.Boolean
  - Indicates whether the Azure cloud account can be onboarded asynchronously.
- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
