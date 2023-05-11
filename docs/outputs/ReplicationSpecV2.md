### ReplicationSpecV2
Replication specification.

- awsRegion: System.String
  - AWS region.
- awsTarget: AwsReplicationTarget
  - AWS location used as the replication target.
- azureRegion: System.String
  - Azure Region.
- azureTarget: AzureReplicationTarget
  - Azure location used as the replication target.
- cascadingArchivalSpecs: a list of CascadingArchivalSpecs
  - Cascading Archival Specifications.
- cluster: SlaReplicationCluster
  - Rubrik cluster used as the replication target.
- replicationLocalRetentionDuration: Duration
  - Time snapshot is kept on local target cluster.
- retentionDuration: Duration
  - Retention duration.
- targetMapping: TargetMapping
  - Replication target mapping.
