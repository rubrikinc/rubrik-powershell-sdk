### StartAzureCloudAccountOauthInput
Input for initiating authentication of the Azure Cloud Accounts.

- tenantDomainName: System.String
  - Domain name of the Azure Tenant.
- isEntraIdInitiatedOnboarding: System.Boolean
  - Indicates that this OAuth flow is an Entra ID initiated Event Hub onboarding, which is authorized in the Entra ID data-source domain rather than the cloud-native domain.
- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- azureRubrikAppUseCase: AzureRubrikAppUseCase
  - Use case for Azure OAuth flow. Possible values: DEFAULT, AZURE_DEVOPS.
