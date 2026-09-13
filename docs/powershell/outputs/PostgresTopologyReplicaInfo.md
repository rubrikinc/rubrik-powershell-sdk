### PostgresTopologyReplicaInfo
Replica details for a PostgreSQL HA cluster, including the Postgres engine version and listen port.

- replicaId: System.String
  - Stable identifier for the replica.
- replicaName: System.String
  - Display name for the replica.
- hostId: System.String
  - Unique identifier of the host that runs this replica.
- role: KosmosTopologyReplicaRole
  - Replica role within the HA topology.
- status: KosmosTopologyReplicaStatus
  - Current status of the replica.
- statusMessages: list of System.Strings
  - Free-form messages describing the replica status (e.g. validation failure reasons, replication lag warnings).
- statusMessageDetails: list of KosmosUserMessages
  - Structured messages describing the replica status (e.g. validation failure reasons, replication lag warnings). Superset of the data in statusMessages, carrying severity/messageCode/cause/remedy as separate fields instead of one formatted string.
- postgresVersion: System.String
  - PostgreSQL engine version string (e.g. "14.5"). Returns null when not yet discovered.
- portNumber: System.Int32
  - Port the Postgres instance listens on for this replica. Returns null when not configured.
