### AzureOauthConsentCompleteInput
Configuration for the completion of an Azure OAuth consent flow.

- tenantId: System.String
  - ID of the Microsoft 365 tenant.
- code: System.String
  - Authorization code for the consent flow.
- stateToken: System.String
  - CSRF token for the setup flow.
- redirectUrl: System.String
  - Redirect URL for the consent flow.
- azureAppId: System.String
  - ID of the Azure app.
- azureAppSecret: System.String
  - Secret for the Azure app.
- azureCloudType: O365AzureCloudType
  - Cloud type for Azure.
