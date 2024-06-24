### AwsCustomerManagedExocomputeConfig
AWS Customer Managed Exocompute Configuration in a region.

- clusterName: System.String
- configUuid: System.String
  - Exocompute configuration UUID.
- message: System.String
  - Exocompute configuration message.
- region: AwsCloudAccountRegion
  - Exocompute configuration region.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
- latestExoclusterDetails: ExocomputeClusterDetails
  - Details of the latest Exocompute cluster.
- hasPcr: System.Boolean
  - Whether this Exocompute uses a Private Container Registry (PCR).
- pcrUrl: System.String
  - URL of the user's PCR.
