### AzureExocomputeGetConfigResponse
Azure Exocompute configuration.

- configUuid: System.String
  - Unique ID of the Exocompute configuration.
- region: AzureCloudAccountRegion
  - Azure region for the cloud account in which exocompute is configured.
- subnetNativeId: System.String
  - Native ID of cluster subnet corresponding to the Exocompute configuration. This subnet will be used to allocate IP addresses to the nodes of the cluster. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni.
- podSubnetNativeId: System.String
  - Native ID of cluster subnet corresponding to the Exocompute configuration. This subnet will be used to allocate IP addresses to the nodes of the cluster. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni.
- isRscManaged: System.Boolean
  - Specifies if Exocompute is managed by RSC.
- message: System.String
  - Specifies the error message received if any.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
