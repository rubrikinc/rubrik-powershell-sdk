### RecoverCloudClusterInput
Recover a Rubrik Cloud Cluster.

- adminPassword: System.String
  - Cloud account password.
- userEmail: System.String
  - Cloud account email.
- cloudAccountId: System.String
  - Customer cloud account ID.
- clusterUuid: System.String
  - Cluster UUID.
- azureEsResourceGroup: System.String
  - Elastic Storage resource group for Azure account.
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
- ntpServers: list of System.Strings
  - Array of NTP servers.
