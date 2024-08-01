### CustomizedRestoreFormConfigurationS3ArchivalLocationInput
Supported in v7.0+

- kmsMasterKeyId: System.String
  - Supported in v7.0+
      KMS master key ID of the archival location.
- pemFileContent: System.String
  - Supported in v7.0+
      Content of the pem file for the archival location.
- secretKey: System.String
  - Supported in v7.0+
      Secret key of the archival location.
- accessKey: System.String
  - Supported in v8.0+
      Access key for archival location.
- encryptionPassword: System.String
  - Supported in v8.0+
      Encryption password of the archival location.
- shouldRecoverSnappableMetadataOnly: System.Boolean
  - Supported in v8.0+
      A Boolean value that determines whether recovery from an archival location includes metadata from the snapshot and the protected object. When the value is 'true', recovery only includes metadata from the protected object. When the value is 'false', recovery includes metadata for the protected object and the snapshot.
- archivalProxyConfig: CustomizedRestoreFormConfigurationArchivalProxyConfigInput
  - Supported in v7.0+
      Archival proxy details.
- computeProxyConfig: CustomizedRestoreFormConfigurationComputeProxyConfigInput
  - Supported in v7.0+
      Compute proxy details.
- restoreFormConfigurationS3ArchivalLocation: RestoreFormConfigurationS3ArchivalLocationInput
  - 
