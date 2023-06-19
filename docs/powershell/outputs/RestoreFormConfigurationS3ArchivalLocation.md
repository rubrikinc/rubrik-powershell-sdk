### RestoreFormConfigurationS3ArchivalLocation
Supported in v7.0+

- archivalProxyConfig: RestoreFormArchivalProxyConfig
  - Supported in v7.0+
  Archival proxy config.
- computeProxyConfig: RestoreFormComputeProxyConfig
  - Supported in v7.0+
  Compute proxy details.
- name: System.String
  - Required. Supported in v7.0+
  Name of the S3 archival location.
- bucket: System.String
  - Supported in v8.0+
  Name of the bucket.
- defaultRegion: System.String
  - Supported in v8.0+
  Default region for archival location.
- encryptionType: System.String
  - Supported in v8.0+
  Method used to encrypt archival location.
- cloudRehydrationSpeed: System.String
  - Supported in v8.1+
  Specifies the retrieval speed option when retrieving data from the cold storage tier to the hot storage tier for restore purposes.
- storageClass: System.String
  - Supported in v8.1+
  Specifies the storage class configured for the archival location.
