### AzureCloudAccountTenantWithExoConfigs
Azure Cloud Account Tenant with details of exocompute configured for subscriptions for a given feature.

- rubrikId: System.String
  - Rubrik ID of the Azure Tenant.
- domainName: System.String
  - Azure Active Directory (AD) domain corresponding to subscription.
- subscriptionCount: System.Int32
  - Number of subscriptions for the tenant.
- clientId: System.String
  - Client ID of azure application for the tenant.
- cloudType: AzureCloudType
  - Type of Azure Tenant. Can be Azure Public Cloud or Azure China Cloud.
- appName: System.String
  - App name of Azure application for the tenant.
- isAppRubrikManaged: System.Boolean
  - If Rubrik manages the application associated with this tenant, this field will be set to FALSE. However, if the application is customer-managed and the customers manually added the credentials, this field will have a different value.
- entraIdGroupId: System.String
  - Object ID of the Entra ID group used for Entra ID authentication in Exocompute. Field will be empty for use cases other than exocompute or if customer has not onboarded to Entra ID authentication.
- subscriptions: list of AzureSubscriptionWithExoConfigss
  - Details of subscriptions for the tenant.
