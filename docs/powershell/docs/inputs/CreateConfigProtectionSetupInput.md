### CreateConfigProtectionSetupInput
Configuration to setup config protection for the cluster.

- clusterUuid: System.String
  - UUID of the cluster.
- encryptionPassword: System.String
  - Password for the backup encryption.
- caCertificate: ConfigProtectionCaCert
  - Details of the CA certificate.
- replicationTargetUuid: System.String
  - UUID of the replication target.
- uploadLocationType: UploadLocationType
  - Upload location type.
