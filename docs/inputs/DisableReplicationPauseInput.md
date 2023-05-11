### DisableReplicationPauseInput
Input for disabling replication per location pause.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- disablePerLocationPause: DisablePerLocationPauseInput
  - Required. A configuration value that specifies which source clusters resume replication. Snapshots taken before or during the replication pause can be skipped.
