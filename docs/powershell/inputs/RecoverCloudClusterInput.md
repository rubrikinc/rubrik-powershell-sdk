### RecoverCloudClusterInput
Recover a Rubrik Cloud Cluster.

- cloudAccountId: System.String
  - Customer cloud account ID.
- clusterUuid: System.String
  - Cluster UUID.
- azureVmConfig: AzureVmConfig
  - Azure virtual machine configuration.
- azureEsResourceGroup: System.String
  - Elastic Storage resource group for Azure account.
- awsVmConfig: AwsVmConfig
  - AWS virtual machine configuration.
- awsRegion: System.String
  - AWS region.
- shouldDisableAwsApiTermination: System.Boolean
  - Should disable AWS API termination.
- gcpVmConfig: GcpVmConfigInput
  - GCP virtual machine configuration.
- gcpZone: System.String
  - GCP zone.
- shouldKeepClusterOnFailure: System.Boolean
  - Should keep Cloud Cluster on failure.
- adminPassword: System.String
  - Cloud account password.
- userEmail: System.String
  - Cloud account email.
- ntpServers: list of System.Strings
  - Array of NTP servers.
