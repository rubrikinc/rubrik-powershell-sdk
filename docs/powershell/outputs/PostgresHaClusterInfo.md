### PostgresHaClusterInfo
HA cluster configuration and replica topology for a PostgreSQL database cluster.

- haGroupName: System.String
  - User-defined label grouping replicas into an HA cluster.
- activeReplicaId: System.String
  - ID of the currently active (primary data source) replica. Null when the active replica cannot be determined.
- replicas: list of KosmosTopologyReplicaInfos
  - Topology replicas in this HA cluster. Might be empty prior to first discovery run.
