### AzureExocomputeConfigDetails
Exocompute configurations details.

- configUuid: System.String
  - ID for exocompute configuration.
- region: AzureCloudAccountRegion
  - Region in which exocompute is configured. It will be in the format like EASTUS.
- subnetNativeId: System.String
  - Native ID of cluster subnet corresponding to the Exocompute configuration. This subnet will be used to allocate IP addresses to the nodes of the cluster. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni.
- podSubnetNativeId: System.String
  - Native ID of cluster subnet corresponding to the Exocompute configuration. This subnet will be used to allocate IP addresses to the nodes of the cluster. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni.
- isRscManaged: System.Boolean
  - Specifies if Exocompute is managed by RSC.
- message: System.String
  - Error message received while creating Exocompute configuration.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
