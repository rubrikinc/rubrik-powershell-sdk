### IsCloudClusterDiskUpgradeAvailableInput
Disk upgrade request for a cloud cluster.

- cloudAccountId: System.String
  - Customer cloud account UUID.
- vendor: CcpVendorType
  - Cloud vendor type.
- clusterUuid: System.String
  - Cloud cluster UUID.
- batchSize: System.Int32
  - Size of the batch for migrating the old configuration nodes to new configuration nodes.
- newNodeCount: System.Int32
  - The total count of nodes after migration. This is applicable only when switching the instance type.
- newInstanceType: System.Int32
  - Instance type enum value for the choosen cloud vendor.
- isAzMigration: System.Boolean
  - Specifies whether RSC is migrating the cluster to AZ-resilient mode.
- subnetAzConfigs: list of SubnetAzConfigInputs
  - Target subnet and availability zone pairs for AZ-resilient migration.
