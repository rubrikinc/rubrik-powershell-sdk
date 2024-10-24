### AwsRscManagedExocomputeConfig
AWS RSC Managed Exocompute Configuration in a region.

- vpcId: System.String
  - VPC ID.
- clusterSecurityGroupId: System.String
  - Cluster security group ID.
- nodeSecurityGroupId: System.String
  - Node security group ID.
- subnet1: AwsExocomputeSubnetType
  - First subnet.
- subnet2: AwsExocomputeSubnetType
  - Second subnet.
- areSecurityGroupsRscManaged: System.Boolean
  - Specifies if the security groups are managed by RSC.
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
- pcrLatestApprovedBundleVersion: System.String
  - Latest approved exotask bundle version for your Private Container Registry.
- pcrImagePullAwsNativeId: System.String
  - AWS native account ID authorized to pull images from Rubrik's Elastic Container Registry.
