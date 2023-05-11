### AzureCloudAccountTenant
Azure Tenant with details of subscriptions that are configured for a given feature.

- appName: System.String
  - App name of the application configured for authentication of the Azure tenant.
- azureCloudAccountTenantRubrikId: System.String
  - Rubrik ID of the Azure Tenant.
- clientId: System.String
  - Client ID of the application configured for authentication of the Azure tenant.
- cloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- domainName: System.String
  - Domain Name of the Azure Tenant.
- subscriptionCount: System.Int32
  - Count of subscriptions added to the Rubrik ecosystem for this Azure Tenant.
- subscriptions: a list of AzureCloudAccountSubscriptionDetails
  - Subscriptions added to the Rubrik ecosystem for this Azure Tenant.
