### RestoreConfigProtectionBackupInput
Configuration to restore config protection backup on the cluster.

- backupClusterUuid: System.String
  - UUID of the cluster which needs to be restored.
- caSignedCsr: System.String
  - Cluster certificate signing request signed by certificate authority.
- restoreBackupRequestDetails: RestoreConfigBackupInput
  - Settings to restore configuration backup.
- useDefaultConfigurations: System.Boolean
  - Specifies if the default settings for a configuration type should be used during restore if configuration information is not provided.
