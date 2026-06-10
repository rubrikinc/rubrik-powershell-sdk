### KosmosTopologyReplicaInfo
Per-replica details for a Kosmos HA topology. Reusable across any HA
workload (Postgres, MySQL, MariaDB).

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
  - Free-form messages describing the replica status (e.g. validation
failure reasons, replication lag warnings).
