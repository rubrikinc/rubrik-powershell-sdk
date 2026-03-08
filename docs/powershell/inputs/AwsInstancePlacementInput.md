### AwsInstancePlacementInput
InstancePlacement specifies the placement configuration for an EC2 instance.

- tenancyType: AwsInstanceTenancyType
  - Tenancy type for the exported EC2 instance.
- hostId: System.String
  - ID of the AWS Dedicated Host. Required when tenancy type is HOST
and host_resource_group_arn is not specified.
Mutually exclusive with hostResourceGroupArn.
- hostResourceGroupArn: System.String
  - ARN of the host resource group. Required when tenancy type is HOST
and host_id is not specified. Mutually exclusive with hostId.
