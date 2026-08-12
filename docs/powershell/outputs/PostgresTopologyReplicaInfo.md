### PostgresTopologyReplicaInfo
Replica details for a PostgreSQL HA cluster, including the Postgres engine version.

- hostId: System.String
  - Unique identifier of the host that runs this replica.
- replicaId: System.String
  - Stable identifier for the replica.
- replicaName: System.String
  - Display name for the replica.
- role: KosmosTopologyReplicaRole
  - Replica role within the HA topology.
- status: KosmosTopologyReplicaStatus
  - Current status of the replica.
- statusMessages: list of System.Strings
  - Free-form messages describing the replica status (e.g. validation failure reasons, replication lag warnings).
- postgresVersion: System.String
  - PostgreSQL engine version string (e.g. "14.5"). Returns null when not yet discovered.
