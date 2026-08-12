### MysqldbHaClusterConfigInput
HA cluster configuration for a MySQL instance with one or more replicas.

- replicas: list of MysqldbHaReplicaConfigInputs
  - Required. List of replicas in this HA cluster. On a patch, send only the replicas you want to change: replicas not included are left unchanged, and a replica is removed only via an explicit shouldDeleteReplica. At most one replica may carry a PRIMARY role hint; zero is allowed (all-standby clusters are supported).
- backupNodePreference: BackupNodePreferenceInput
  - Optional customer preference for which replica(s) the backup scheduler
picks as the source. When absent or null in the request body the stored
value is left unchanged. When present it is validated and persisted.
Note: HA clusters use the shared unsorted.kosmos_models.BackupNodePreference
object (a strategy enum with values PRIMARY_ONLY, STANDBY_ONLY, ANY, or
PREFER_STANDBY, plus orderedReplicaPreferences and excludedReplicaIds).
This is intentionally distinct from the standalone MysqldbBackupPreference
string enum (Primary or ReplicaOnly), which applies only to non-HA
instances.
