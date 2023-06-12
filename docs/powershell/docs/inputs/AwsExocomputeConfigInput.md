### AwsExocomputeConfigInput
AWS exocompute configuration to add.

- region: AwsCloudAccountRegion
  - The region for which the configuration is specified.
- clusterSecurityGroupId: System.String
  - AWS ID of cluster control plane security group. If isRscManaged is true, this parameter is optional.
- vpcId: System.String
  - AWS ID of the VPC.
- nodeSecurityGroupId: System.String
  - AWS ID of worker node security group. If isRscManaged is true, this parameter is optional.
- subnets: list of AwsExocomputeSubnetInputTypes
  - List of exactly 2 subnets.
- isRscManaged: System.Boolean
  - If security groups are to be managed by Rubrik Security Cloud, this parameter should be set to true. False, if users are in charge of managing security groups.
