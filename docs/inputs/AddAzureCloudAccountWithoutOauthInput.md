### AddAzureCloudAccountWithoutOauthInput
Input for adding an Azure Cloud Account without OAuth.

- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- regions: a list of AzureCloudAccountRegions
  - Regions to be added to the Azure Cloud Account.
- subscriptions: a list of AddAzureCloudAccountSubscriptionInputWithoutOauths
  - Subscriptions to be added to the Azure Cloud Account.
- tenantDomainName: System.String
  - Domain Name of the Azure tenant.
