### RecoverCloudClusterInput
Recover a Rubrik Cloud Cluster.

- cloudAccountId: System.String
  - Customer cloud account ID.
- clusterUuid: System.String
  - Cluster UUID.
- azureVmConfig: AzureVmConfig
  - Azure virtual machine configuration.
- awsVmConfig: AwsVmConfig
  - AWS virtual machine configuration.
- awsRegion: System.String
  - AWS region.
- shouldDisableAwsApiTermination: System.Boolean
  - Should disable AWS API termination.
- shouldKeepClusterOnFailure: System.Boolean
  - Should keep Cloud Cluster on failure.
