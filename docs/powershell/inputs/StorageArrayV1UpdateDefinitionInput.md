### StorageArrayV1UpdateDefinitionInput
Definition for updating a storage array.

- apiToken: System.String
  - Supported in v9.6+
API token for the storage array. Required when isVolumeProtectionEnabled is true and no API token is already stored. If omitted and an API token already exists, the existing value is kept.
- isVolumeProtectionEnabled: System.Boolean
  - Required. Supported in v9.6+
Specifies whether Volume Protection features are enabled for this storage array. When true, apiToken must either be provided in the request or already stored on the array.
- arrayType: StorageArrayType
  - Required. Supported in v9.6+
- caCerts: System.String
  - Supported in v9.6+
A digital certificate, or concatenated chain of digital certificates, that permits verification of the public key certificate of the storage array. Each certificate must be an X.509 certificate in Base64 encoded DER format and must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- certificateId: System.String
  - Supported in v9.6+
The ID corresponding to the imported certificate.
- isSnapshotOffloadingEnabled: System.Boolean
  - Required. Supported in v9.6+
Specifies whether Array Integration (Snapshot Offloading) features are enabled for this storage array. When true, username and password must either be provided in the request or already stored on the array.
- password: System.String
  - Supported in v9.6+
Password for the storage array. Required when isSnapshotOffloadingEnabled is true and no password is already stored. If omitted and a password already exists, the existing value is kept.
- hostname: System.String
  - Required. Supported in v9.6+
Resolvable hostname or IPv4 address of the storage array.
- username: System.String
  - Supported in v9.6+
Username for the storage array. Required when isSnapshotOffloadingEnabled is true and no username is already stored. If omitted and a username already exists, the existing value is kept.
