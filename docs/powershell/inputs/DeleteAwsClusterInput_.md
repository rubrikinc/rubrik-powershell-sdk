### DeleteAwsClusterInput
DeleteAwsClusterInput for Aws account.

- cloudAccountId: System.String
  - Cloud account ID of the AWS account.
- numNodes: System.Int32
  - Number of nodes in the existing cluster.
- isEsType: System.Boolean
  - True if the cluster is CC-ES, and false for disk based.
- bucketName: System.String
  - Name of the s3 bucket for CC-ES.
- isNewContainer: System.Boolean
  - True if the container was created as part of the cluster, and needs to be deleted as well.
- clusterUuid: System.String
  - Uuid of the cluster.
- region: System.String
  - Region name of the aws account.
