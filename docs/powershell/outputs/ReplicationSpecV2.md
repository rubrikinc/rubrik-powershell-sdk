### ReplicationSpecV2
Replication specification.

- retentionDuration: Duration
  - Retention duration.
- replicationLocalRetentionDuration: Duration
  - Time snapshot is kept on local target cluster.
- cascadingArchivalSpecs: list of CascadingArchivalSpecs
  - Cascading Archival Specifications.
- targetMapping: TargetMapping
  - Replication target mapping.
- cluster: SlaReplicationCluster
  - Rubrik cluster used as the replication target.
- awsRegion: System.String
  - AWS region.
- azureRegion: System.String
  - Azure Region.
- awsTarget: AwsReplicationTarget
  - AWS location used as the replication target.
- azureTarget: AzureReplicationTarget
  - Azure location used as the replication target.
