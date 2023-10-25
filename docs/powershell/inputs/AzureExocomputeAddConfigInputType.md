### AzureExocomputeAddConfigInputType
Azure exocompute configuration to add.

- region: AzureCloudAccountRegion
  - The region for which the configuration is specified.
- subnetNativeId: System.String
  - Subnet native ID where exocompute cluster should be launched.
- isRscManaged: System.Boolean
  - Specifies if this configuration is managed by Rubrik.
- podSubnetNativeId: System.String
  - Native ID of the subnet where the Exocompute pods should be launched.
- podOverlayNetworkCidr: System.String
  - The CIDR range for pods if Exocompute is launched with the CNI overlay network plugin.
