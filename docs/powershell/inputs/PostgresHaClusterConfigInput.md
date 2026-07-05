### PostgresHaClusterConfigInput
Supported in v9.6+
HA cluster configuration for PostgreSQL with multiple replicas.

- haGroupName: System.String
  - Required. Supported in v9.6+
User-defined label grouping these replicas into an HA cluster.
- replicas: list of PostgresHaReplicaConfigInputs
  - Required. Supported in v9.6+
List of replicas in this HA cluster. Minimum 2 required.
- backupNodePreference: BackupNodePreferenceInput
  - Supported in v9.6+
Optional customer preference for which replica(s) the backup
scheduler picks as source. When absent or null in the request
body the column is left unchanged. When present with a value
the preference is validated and persisted.
