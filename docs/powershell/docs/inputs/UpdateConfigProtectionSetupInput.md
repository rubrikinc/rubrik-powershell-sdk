### UpdateConfigProtectionSetupInput
Configuration to update config protection set up for the cluster.

- clusterUuid: System.String
  - UUID of the cluster.
- encryptionPassword: System.String
  - New password for the backup encryption.
- caCertificate: ConfigProtectionCaCert
  - Details of the new CA certificate.
- replicationTargetUuid: System.String
  - UUID of the new replication target.
- uploadLocationType: UploadLocationType
  - New upload location type.
