### KmsSpecInput
Azure KMS configuration, excluding the app secret.

- appId: System.String
  - The ID of the client app.
- appSecret: System.String
  - The secret of the client app. Deprecated and will be removed soon.
- cloudType: O365AzureCloudType
  - The cloud type. The allowed values are PUBLIC and USGOV.
- kekNameColossus: System.String
  - The key encryption key (KeK) name for Colossus.
- keyName: System.String
  - The key encryption key (KeK) name.
- kmsId: System.String
  - The complete ID of the Azure Key Vault.
- tenantId: System.String
  - The tenant hosting the Azure Key Vault.
