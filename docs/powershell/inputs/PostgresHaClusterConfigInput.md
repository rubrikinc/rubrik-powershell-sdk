### PostgresHaClusterConfigInput
HA cluster configuration for PostgreSQL with multiple replicas.

- haGroupName: System.String
  - Required. User-defined label grouping these replicas into an HA cluster.
- replicas: list of PostgresHaReplicaConfigInputs
  - Required. List of replicas in this HA cluster. Minimum 2 required.
