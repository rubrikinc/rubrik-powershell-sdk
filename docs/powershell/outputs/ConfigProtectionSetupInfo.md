### ConfigProtectionSetupInfo
Configuration protection setup information for a cluster.

- caCertUuid: System.String
  - UUID of the CA certificate used for the setup.
- caCertName: System.String
  - Name of the CA certificate used for the setup.
- replicationTargetUuid: System.String
  - UUID of the replication cluster used for storing configuration backup.
- replicationTargetName: System.String
  - Name of the replication cluster used for storing configuration backup.
- caCertProvider: CaCertProviderType
  - CA certificate provider type.
- uploadLocationType: UploadLocationType
  - Upload location type.
