### ReplicationSpecV2Input
Replication specification.

- clusterUuid: System.String
  - Cluster UUID.
- storageSettingId: System.String
  - Storage setting ID.
- retentionDuration: SlaDurationInput
  - Retention duration.
- awsAccount: System.String
  - AWS account.
- azureSubscription: System.String
  - Azure subscription.
- replicationLocalRetentionDuration: SlaDurationInput
  - Time snapshot is kept on local target cluster.
- cascadingArchivalSpecs: list of CascadingArchivalSpecInputs
  - Cascading Archival Specifications.
- replicationPairs: list of ReplicationPairInputs
  - Datacenter replication pairs.
- awsRegion: AwsNativeRegionForReplication
  - AWS region.
- azureRegion: AzureNativeRegionForReplication
  - Azure region.
