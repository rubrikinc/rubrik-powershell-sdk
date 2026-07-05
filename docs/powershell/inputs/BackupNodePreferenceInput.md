### BackupNodePreferenceInput
Supported in v9.6+
User preference for which node(s) to use for backups in an HA cluster.

- excludedReplicaIds: list of System.Strings
  - Supported in v9.6+
List of KosmosTopologyReplica IDs that should not be used for backups. Identifies specific replicas (not hosts).
- orderedReplicaPreferences: list of System.Strings
  - Supported in v9.6+
Ordered list of KosmosTopologyReplica IDs indicating preference for the backup source replica. First entry is most preferred. Identifies a specific replica (not a host); the same host can back multiple replicas, so hostId is not unique.
- strategy: BackupNodePreferenceStrategy
  - Required. Supported in v9.6+
Backup node selection strategy. PRIMARY_ONLY takes backups from the primary only. STANDBY_ONLY takes backups from standby replicas only. ANY allows any node. PREFER_STANDBY prefers standby but falls back to primary.
