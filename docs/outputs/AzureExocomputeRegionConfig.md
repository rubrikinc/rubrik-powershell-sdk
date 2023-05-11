### AzureExocomputeRegionConfig
Represents an Azure Exocompute Configuration for a specific region. The Azure Exocompute Configuration includes the subnet native ID to be used for launching an Azure Kubernetes Service (AKS) Cluster in a specific region.

- isRscManaged: System.Boolean
  - Specifies whether Exocompute is managed by Rubrik or not.
- podSubnetNativeId: System.String
  - Native ID of the subnet, configured for usage in this region for the Exocompute pods.
- region: AzureCloudAccountRegion
  - Azure region for the cloud account in which exocompute is configured.
- subnetNativeId: System.String
  - Native ID of the subnet, configured for usage in this region for the Exocompute cluster.
