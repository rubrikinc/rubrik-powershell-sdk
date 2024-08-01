### AwsExocomputeGetConfigResponse
AWS Exocompute configuration in a region.

- configUuid: System.String
  - Exocompute configuration UUID.
- region: AwsCloudAccountRegion
  - Exocompute configuration region.
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
- message: System.String
  - Exocompute configuration message.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
- hasPcr: System.Boolean
  - Whether this Exocompute uses a Private Container Registry (PCR).
- pcrUrl: System.String
  - URL of the user's PCR.
- areSecurityGroupsRscManaged: System.Boolean
  - Specifies if the security groups are managed by Rubrik SaaS.
