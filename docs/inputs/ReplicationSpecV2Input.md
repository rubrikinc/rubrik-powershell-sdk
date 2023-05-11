### ReplicationSpecV2Input
Replication specification.

- awsAccount: System.String
  - AWS account.
- awsRegion: AwsNativeRegionForReplication
  - AWS region.
- azureRegion: AzureNativeRegionForReplication
  - Azure region.
- azureSubscription: System.String
  - Azure subscription.
- cascadingArchivalSpecs: a list of CascadingArchivalSpecInputs
  - Cascading Archival Specifications.
- clusterUuid: System.String
  - Cluster UUID.
- replicationLocalRetentionDuration: SlaDurationInput
  - Time snapshot is kept on local target cluster.
- retentionDuration: SlaDurationInput
  - Retention duration.
- storageSettingId: System.String
  - Storage setting ID.
