### AwsExocomputeGetConfigResponse
AWS Exocompute configuration in a region.

- areSecurityGroupsRscManaged: System.Boolean
  - Specifies if the security groups are managed by Rubrik SaaS.
- clusterSecurityGroupId: System.String
  - Cluster security group ID.
- configUuid: System.String
  - Exocompute configuration UUID.
- healthCheckStatus: ExocomputeHealthCheckStatus
  - Status of the latest Exocompute health check.
- message: System.String
  - Exocompute configuration message.
- nodeSecurityGroupId: System.String
  - Node security group ID.
- region: AwsCloudAccountRegion
  - Exocompute configuration region.
- subnet1: AwsExocomputeSubnetType
  - First subnet.
- subnet2: AwsExocomputeSubnetType
  - Second subnet.
- vpcId: System.String
  - VPC ID.
