### CreateAwsClusterInput
CreateAwsClusterInput for Aws account.

- cloudAccountId: System.String
  - Cloud account ID of the AWS account.
- clusterConfig: ClusterConfigInput
  - Cluster configuration to initialize cluster.
- disableApiTermination: System.Boolean
  - Disable API termination on AWS instances.
- isEsType: System.Boolean
  - Create disk based or CCES.
- keepClusterOnFailure: System.Boolean
  - Flag to keep the cluster on failure.
- region: System.String
  - Aws region.
- vmConfig: AwsVmConfig
  - Virtual Machine configuration to create nodes.
