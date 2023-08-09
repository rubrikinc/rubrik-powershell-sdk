### AzureCloudAccountTenant
Azure Tenant with details of subscriptions that are configured for a given feature.

- azureCloudAccountTenantRubrikId: System.String
  - Rubrik ID of the Azure Tenant.
- domainName: System.String
  - Domain Name of the Azure Tenant.
- subscriptionCount: System.Int32
  - Count of subscriptions added to the Rubrik ecosystem for this Azure Tenant.
- subscriptions: list of AzureCloudAccountSubscriptionDetails
  - Subscriptions added to the Rubrik ecosystem for this Azure Tenant.
- clientId: System.String
  - Client ID of the application configured for authentication of the Azure tenant.
- cloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- appName: System.String
  - App name of the application configured for authentication of the Azure tenant.
- isAppRubrikManaged: System.Boolean
  - If Rubrik manages the application associated with this tenant, this field will be set to FALSE. However, if the application is customer-managed and the customers manually added the credentials,this field will have a different value.
