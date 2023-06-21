### DisablePerLocationPauseInput
Supported in v5.3+

- shouldSkipOldSnapshots: System.Boolean
  - Required. Supported in v5.3+
      Specifies whether to replicate snapshots taken during and before replication pause. When this value is 'true,' snapshots taken during and before the replication pause are not replicated. In all other cases, snapshots taken before and during the replication pause are replicated.
- sourceClusterUuids: list of System.Strings
  - Required. Supported in v5.3+
      Replication from specified Rubrik clusters are resumed. Specified Rubrik clusters must be paused replication sources of local Rubrik cluster.
