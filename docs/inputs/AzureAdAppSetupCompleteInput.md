### AzureAdAppSetupCompleteInput
Configuration to complete the Azure AD Application creation flow.

- domainName: System.String
  - Domain name of the MSFT tenant for which the application was created.
- kmsSpec: KmsSpecInput
  - Azure KMS configuration.
- region: AzureCommonRegion
  - Azure region name.
- stateToken: System.String
  - CSRF token for the setup flow.
