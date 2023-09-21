### CompleteAzureAdAppSetupInput
Configuration to complete the Azure AD application creation flow.

- domainName: System.String
  - Domain name of the MSFT tenant for which the application was created.
- stateToken: System.String
  - CSRF token from the setup flow.
- kmsSpec: KmsSpecInput
  - Azure KMS configuration.
