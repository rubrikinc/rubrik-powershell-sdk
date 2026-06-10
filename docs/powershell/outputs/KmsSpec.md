### KmsSpec
KmsSpec stores the values required for CRUD on keys in the required KMS.
The app details can be either of the Rubrik App or customer App (for BYOK).

- cloudType: O365AzureCloudType
  - The cloud type. The allowed values are PUBLIC and USGOV.
- tenantId: System.String
  - The tenant for the app.
- kmsId: System.String
  - ID of the KMS. If is_uem_managed is true, this would refer to the
UEM kms ID, which is not necessarily Azure ID. The usage pattern is
to request the KMS details from UEM APIs.
- appId: System.String
  - The ID of the client app.
- appSecret: System.String
  - The secret of the client app. The app_secret will not be transmitted over grpc endpoints, it will be
read from DB where required. Deprecated and will be removed soon.
- keyName: System.String
  - The key encryption key (KeK) name.
- kekNameColossus: System.String
  - The key encryption key (KeK) name for Colossus.
