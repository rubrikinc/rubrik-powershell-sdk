### UpdateConfigProtectionSetupInput
Configuration to update config protection set up for the cluster.

- caCertificate: ConfigProtectionCaCert
  - Details of the new CA certificate.
- clusterUuid: System.String
  - UUID of the cluster.
- encryptionPassword: System.String
  - New password for the backup encryption.
- replicationTargetUuid: System.String
  - UUID of the new replication target.
- uploadLocationType: UploadLocationType
  - New upload location type.
