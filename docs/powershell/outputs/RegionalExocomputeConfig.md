### RegionalExocomputeConfig
Contains the region and subnet configuration.

- vpcNetworkName: System.String
  - Name of the VPC network.
- region: GcpCloudAccountRegion
  - Region for which the subnet is configured.
- subnetName: System.String
  - Name of the subnet.
- projectId: System.String
  - Project ID of the project containing the VPC network.
- clusterSecondaryRangeName: System.String
  - Name of the GKE pods secondary IP range on the subnet. If not provided
the default value "pods-cidr-range" is used.
