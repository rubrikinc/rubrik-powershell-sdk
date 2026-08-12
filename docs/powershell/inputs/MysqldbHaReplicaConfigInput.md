### MysqldbHaReplicaConfigInput
Per-replica configuration for an HA MySQL cluster.

- shouldDeleteReplica: System.Boolean
  - Set to true to remove this replica from the cluster; this requires the replicaId of an existing replica. When false or omitted, the replica is kept and its supplied fields are updated. Replicas not included in the request are left unchanged.
- role: MysqldbHaReplicaConfigRole
  - User-intended role hint for this replica. Used as the initial seeded role - discovery confirms or corrects the actual role.
- replicaId: System.String
  - System-generated unique ID for this replica. Omit (or empty string) when adding a new replica - the system assigns an ID. Provide the existing ID when patching an existing replica.
- connectionInfo: MysqldbReplicaConnectionInfoInput
  - Per-replica overrides of the cluster-level connection/auth settings.
- hostId: System.String
  - ID of the host where this replica runs. Multiple replicas may share a hostId (different ports). Required when adding a new replica on create. On a PATCH the server merges the request into the stored replica, so an omitted hostId preserves the existing value.
- replicaName: System.String
  - User-chosen display label for this replica. Required when adding a new replica on create. On a PATCH the server merges the request into the stored replica, so an omitted replicaName preserves the existing value.
