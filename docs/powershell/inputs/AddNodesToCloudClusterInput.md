### AddNodesToCloudClusterInput
Nodes add request for a cloud cluster.

- numberOfNodes: System.Int32
  - Number of nodes to add.
- awsImageId: System.String
  - AWS AMI ID to deploy to add nodes to an AWS Cloud Cluster without the marketplace.
- azureImageName: System.String
  - Azure image name to deploy to add nodes to an Azure Cloud Cluster without the marketplace.
- cloudAccountId: System.String
  - Customer cloud account UUID.
- vendor: CcpVendorType
  - Cloud vendor type.
- clusterUuid: System.String
  - Cluster UUID.
- shouldKeepResourcesOnFailure: System.Boolean
  - Specifies whether node resources are preserved if the add node operation fails.
