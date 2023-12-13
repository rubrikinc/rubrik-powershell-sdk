### AwsCustomerManagedExocomputeConfig
AWS Customer Managed Exocompute Configuration in a region.

- clusterName: System.String
  - Exocompute cluster name.
- configUuid: System.String
  - Exocompute configuration UUID.
- message: System.String
  - Exocompute configuration message.
- region: AwsCloudAccountRegion
  - Exocompute configuration region.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
- hasPcr: System.Boolean
  - Whether this Exocompute uses a Private Container Registry (PCR).
- pcrUrl: System.String
  - URL of the user's PCR.
