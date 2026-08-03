### StorageArrayV1DefinitionInput
Definition of a storage array to add.

- apiToken: System.String
  - Supported in v9.6+
API token for the storage array. Required for Volume Protection features. Optional for Array Integration features.
- isVolumeProtectionEnabled: System.Boolean
  - Supported in v9.6+
Specifies whether Volume Protection features are enabled for this storage array. Optional for backward compatibility - older clients may omit this field. When true, apiToken must be provided in the request.
- arrayType: StorageArrayType
  - Required. Supported in v9.6+
- caCerts: System.String
  - Supported in v9.6+
A digital certificate, or concatenated chain of digital certificates, that permits verification of the public key certificate of the storage array. Each certificate must be an X.509 certificate in Base64 encoded DER format and must start with -----BEGIN CERTIFICATE----- and end with -----END CERTIFICATE-----.
- certificateId: System.String
  - Supported in v9.6+
The ID corresponding to the imported certificate.
- isSnapshotOffloadingEnabled: System.Boolean
  - Supported in v9.6+
Specifies whether Array Integration (Snapshot Offloading) features are enabled for this storage array. Optional for backward compatibility - older clients may omit this field. When true, username and password must be provided in the request.
- password: System.String
  - Supported in v9.6+
Password for the storage array. Required for Array Integration features. Optional for Volume Protection features.
- hostname: System.String
  - Required. Supported in v9.6+
Resolvable hostname or IPv4 address of the storage array.
- username: System.String
  - Supported in v9.6+
Username for the storage array. Required for Array Integration features. Optional for Volume Protection features.
