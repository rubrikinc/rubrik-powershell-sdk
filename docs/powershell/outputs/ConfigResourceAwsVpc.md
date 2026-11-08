### ConfigResourceAwsVpc
AWS VPC specific details for config resources.

- status: AwsVpcStatus
  - VPC status.
- primaryCidr: System.String
  - Primary CIDR block associated with the VPC.
- secondaryCidrs: list of System.Strings
  - Secondary CIDR blocks associated with the VPC.
- totalSubnets: System.Int32
  - Total number of subnets in the VPC.
