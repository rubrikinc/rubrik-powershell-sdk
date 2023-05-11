### SubnetGroup
Represents a subnet group on AWS.

- arn: System.String
  - Amazon Resource Name (ARN) of the subnet group.
- name: System.String
  - Name of the subnet group.
- subnets: a list of AwsNativeSubnets
  - Subnets associated with the subnet group.
- vpcId: System.String
  - Virtual Private Cloud (VPC) corresponding to the subnet group.
