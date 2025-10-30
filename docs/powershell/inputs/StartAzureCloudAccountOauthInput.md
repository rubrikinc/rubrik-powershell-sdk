### StartAzureCloudAccountOauthInput
Input for initiating authentication of the Azure Cloud Accounts.

- tenantDomainName: System.String
  - Domain name of the Azure Tenant.
- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- azureRubrikAppUseCase: AzureRubrikAppUseCase
  - Use case for Azure OAuth flow. Possible values: DEFAULT, AZURE_DEVOPS.
