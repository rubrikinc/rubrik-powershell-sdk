### AwsExocomputeConfigInput
AWS exocompute configuration to add.

- clusterSecurityGroupId: System.String
  - AWS ID of cluster control plane security group. If isRscManaged is true, this parameter is optional.
- isRscManaged: System.Boolean
  - If security groups are to be managed by Rubrik Security Cloud, this parameter should be set to true. False, if users are in charge of managing security groups.
- nodeSecurityGroupId: System.String
  - AWS ID of worker node security group. If isRscManaged is true, this parameter is optional.
- region: AwsCloudAccountRegion
  - The region for which the configuration is specified.
- subnets: a list of AwsExocomputeSubnetInputTypes
  - List of exactly 2 subnets.
- vpcId: System.String
  - AWS ID of the VPC.
