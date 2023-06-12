### SubnetGroup
Represents a subnet group on AWS.

- name: System.String
  - Name of the subnet group.
- arn: System.String
  - Amazon Resource Name (ARN) of the subnet group.
- vpcId: System.String
  - Virtual Private Cloud (VPC) corresponding to the subnet group.
- subnets: list of AwsNativeSubnets
  - Subnets associated with the subnet group.
