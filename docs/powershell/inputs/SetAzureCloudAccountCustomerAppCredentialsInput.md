### SetAzureCloudAccountCustomerAppCredentialsInput
Input for setting the app credentials in the Azure Cloud Accounts.

- appId: System.String
  - Client ID of the Application.
- appSecretKey: System.String
  - Client secret key of the Application.
- appTenantId: System.String
  - ID of the home tenant of the application.
- appName: System.String
  - Name of the application.
- tenantDomainName: System.String
  - Domain Name of the Azure tenant.
- shouldReplace: System.Boolean
  - Specifies whether the input app should replace the existing app.
- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
