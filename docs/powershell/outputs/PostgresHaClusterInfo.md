### PostgresHaClusterInfo
HA cluster configuration and replica topology for a PostgreSQL database cluster.

- haGroupName: System.String
  - User-defined label grouping replicas into an HA cluster.
- activeReplicaId: System.String
  - ID of the currently active (primary data source) replica. Null when the active replica cannot be determined.
- replicas: list of PostgresTopologyReplicaInfos
  - Topology replicas in this HA cluster. Might be empty prior to the first discovery run.
- backupNodePreference: PostgresBackupNodePreference
  - Customer-configured preference for which replica acts as the backup source. Null when not set, or when the strategy is not recognized by this version of Rubrik Security Cloud (version skew).
