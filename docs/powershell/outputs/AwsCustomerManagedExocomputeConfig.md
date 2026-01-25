### AwsCustomerManagedExocomputeConfig
AWS Customer Managed Exocompute Configuration in a region.

- clusterName: System.String
- byokClusterId: System.String
  - Cluster ID of the customer managed exocompute.
- configUuid: System.String
  - Exocompute configuration UUID.
- message: System.String
  - Exocompute configuration message.
- region: AwsCloudAccountRegion
  - Exocompute configuration region.
- authServerRegion: AwsAuthServerBasedCloudAccountRegion
  - Auth server-based region (ISO/ISOB), if applicable.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
- latestExoclusterDetails: ExocomputeClusterDetails
  - Details of the latest Exocompute cluster.
- hasPcr: System.Boolean
  - Whether this Exocompute uses a Private Container Registry (PCR).
- pcrUrl: System.String
  - URL of the user's PCR.
- pcrLatestApprovedBundleVersion: System.String
  - Latest approved exotask bundle version for your Private Container Registry.
- pcrImagePullAwsNativeId: System.String
  - AWS native account ID authorized to pull images from Rubrik's Elastic Container Registry.
- pcrImagePullEksVersion: System.String
  - EKS version corresponding to the latest approved bundle version for PCR customers.
