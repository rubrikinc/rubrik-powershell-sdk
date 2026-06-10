### PostgresHaReplicaConfigInput
Per-replica configuration for a PostgreSQL HA cluster.

- role: PostgresHaReplicaConfigRole
  - User-intended role hint for this replica (e.g. PRIMARY, STANDBY). Used as the initial seeded role - discovery will confirm or correct.
- portNumber: System.Int32
  - Required. Port number of the PostgreSQL instance on this host.
- replicaId: System.String
  - System-generated unique ID for this replica. Omit (or empty string) when adding a new replica - the system assigns an ID. Provide the existing ID when patching an existing replica.
- hostId: System.String
  - Required. ID of the host where this replica runs. Multiple replicas may share a hostId (different ports).
- replicaName: System.String
  - Required. User-chosen display label for this replica.
- username: System.String
  - Optional per-replica DB username. If absent, falls back to empty string (cluster-level loginInfo.username is not used for HA clusters).
