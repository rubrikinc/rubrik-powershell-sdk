### CreateAwsClusterInput
CreateAwsClusterInput for Aws account.

- cloudAccountId: System.String
  - Cloud account ID of the AWS account.
- isEsType: System.Boolean
  - Create disk based or CCES.
- keepClusterOnFailure: System.Boolean
  - Flag to keep the cluster on failure.
- region: System.String
  - Aws region.
- disableApiTermination: System.Boolean
  - Disable API termination on AWS instances.
- clusterConfig: ClusterConfigInput
  - Cluster configuration to initialize cluster.
- vmConfig: AwsVmConfig
  - Virtual Machine configuration to create nodes.
- validations: list of ClusterCreateValidationss
  - Validations to perform on the request.
