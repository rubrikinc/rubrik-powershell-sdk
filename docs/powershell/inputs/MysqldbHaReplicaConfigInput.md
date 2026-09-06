### MysqldbHaReplicaConfigInput
Supported in v9.6+
Per-replica configuration for an HA MySQL cluster.

- shouldDeleteReplica: System.Boolean
  - Supported in v9.6+
Set to true to remove this replica from the cluster; this requires the replicaId of an existing replica. When false or omitted, the replica is kept and its supplied fields are updated. Replicas not included in the request are left unchanged.
- role: MysqldbHaReplicaConfigRole
  - Supported in v9.6+
User-intended role hint for this replica. Used as the initial seeded role - discovery confirms or corrects the actual role.
- perReplicaConnectionInfo: MysqldbReplicaConnectionInfoInput
  - Supported in v9.6+
Per-replica overrides of the cluster-level connection/auth settings.
- replicaId: System.String
  - Supported in v9.6+
System-generated unique ID for this replica. Omit (or empty string) when adding a new replica - the system assigns an ID. Provide the existing ID when patching an existing replica.
- hostId: System.String
  - Supported in v9.6+
ID of the host where this replica runs. Multiple replicas may share a hostId (different ports). Required when adding a new replica on create. On a PATCH the server merges the request into the stored replica, so an omitted hostId preserves the existing value.
- replicaName: System.String
  - Supported in v9.6+
User-chosen display label for this replica. Required when adding a new replica on create. On a PATCH the server merges the request into the stored replica, so an omitted replicaName preserves the existing value.
