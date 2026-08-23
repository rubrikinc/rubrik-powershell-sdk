### MysqlTopologyReplicaInfo
Per-replica details for a MySQL HA topology.

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
- statusMessageDetails: list of KosmosUserMessages
  - Structured messages describing the replica status (e.g. validation failure reasons, replication lag warnings). Superset of the data in statusMessages, carrying severity/messageCode/cause/remedy as separate fields instead of one formatted string.
