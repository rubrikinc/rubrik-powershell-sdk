### KmsSpec
Parameters to build KMS.

- cloudType: O365AzureCloudType
  - The cloud type. The allowed values are PUBLIC and USGOV.
- tenantId: System.String
  - The tenant hosting the Azure Key Vault.
- kmsId: System.String
  - The complete ID of the Azure Key Vault.
- appId: System.String
  - The ID of the client app.
- appSecret: System.String
  - The secret of the client app. Deprecated and will be removed soon.
- keyName: System.String
  - The key encryption key (KeK) name.
- kekNameColossus: System.String
  - The key encryption key (KeK) name for Colossus.
