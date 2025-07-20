### EnablePerLocationPauseInput
Supported in v5.3+

- shouldCancelImmediately: System.Boolean
  - Required. Supported in v5.3+
v5.3-v7.0: Specifies whether replication jobs are canceled immediately. When this value is 'true,' replication jobs will be canceled immediately. In all other cases, current running replication jobs will be allowed to finish before pausing.

v8.0+: Specifies whether replication jobs are canceled immediately. When this value is 'true', replication jobs will be canceled immediately.
- sourceClusterUuids: list of System.Strings
  - Required. Supported in v5.3+
Replication from specified Rubrik clusters are paused. Specified Rubrik clusters must be active replication sources of local Rubrik cluster.
- shouldPauseImmediately: System.Boolean
  - Supported in v8.0+
Specifies whether replication jobs are paused immediately while pulling data from the source cluster. When this value is 'true', replication jobs will be paused immediately without losing their progress. Either 'shouldCancelImmediately' or 'shouldPauseImmediately' must be 'true', but not both at the same time. When both are 'false', current running replication jobs will be allowed to finish before pausing.
