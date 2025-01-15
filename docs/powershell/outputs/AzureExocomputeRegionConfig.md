### AzureExocomputeRegionConfig
Represents an Azure Exocompute Configuration for a specific region. The Azure Exocompute Configuration includes the subnet native ID to be used for launching an Azure Kubernetes Service (AKS) Cluster in a specific region.

- region: AzureCloudAccountRegion
  - Azure region for the cloud account in which Exocompute is configured.
- subnetNativeId: System.String
  - Native ID of the subnet, configured for usage in this region for the Exocompute cluster.
- isRscManaged: System.Boolean
  - Specifies whether Exocompute is managed by Rubrik or not.
- podSubnetNativeId: System.String
  - Native ID of the subnet, configured for usage in this region for the Exocompute pods.
- podOverlayNetworkCidr: System.String
  - The CIDR range assigned for pods when launching Exocompute with the CNI overlay network plugin mode.
- optionalConfig: AzureExocomputeOptionalConfigInRegion
  - Optional configurations for AKS cluster.
