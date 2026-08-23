### PostgresBackupNodePreference
Backup node preference for a PostgreSQL HA cluster.

- strategy: BackupNodePreferenceStrategy
  - Strategy used to select the backup node from the available replicas.
- orderedReplicaPreferences: list of System.Strings
  - Ordered list of preferred replica IDs for backup source selection.
- excludedReplicaIds: list of System.Strings
  - List of replica IDs excluded from being selected as the backup source.
