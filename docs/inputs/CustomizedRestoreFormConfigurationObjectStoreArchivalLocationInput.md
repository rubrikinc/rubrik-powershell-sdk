### CustomizedRestoreFormConfigurationObjectStoreArchivalLocationInput
Supported in v7.0+

- accessKey: System.String
  - Supported in v8.0+
      Access key for archival location.
- pemFileContent: System.String
  - Supported in v7.0+
      Pem file content of archival location.
- restoreFormConfigurationObjectStoreArchivalLocation: RestoreFormConfigurationObjectStoreArchivalLocationInput
  - 
- secretKey: System.String
  - Supported in v7.0+
      Secret key of archival location.
- shouldRecoverSnappableMetadataOnly: System.Boolean
  - Supported in v8.0+
      A Boolean value that determines whether recovery from an archival location includes metadata from the snapshot and the protected object. When the value is 'true', recovery only includes metadata from the protected object. When the value is 'false', recovery includes metadata for the protected object and the snapshot.
