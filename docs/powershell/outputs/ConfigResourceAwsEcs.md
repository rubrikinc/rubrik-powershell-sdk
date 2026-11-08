### ConfigResourceAwsEcs
AWS ECS cluster specific details for config resources.

- capacityProviderStrategy: list of AwsEcsCapacityProviderTypes
  - Distinct capacity modes the cluster can run tasks on. Empty when the
cluster has no capacity providers and no registered container instances.
- vpcId: System.String
  - ID of the VPC the cluster's tasks run in. Empty when no service uses
awsvpc networking.
- vpcName: System.String
  - Name of the VPC identified by vpcId. Empty when the VPC is unknown or
carries no name tag.
