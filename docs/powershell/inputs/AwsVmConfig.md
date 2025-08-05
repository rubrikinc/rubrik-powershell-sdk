### AwsVmConfig
Configuration for creating AWS instances.

- cdmVersion: System.String
  - Rubrik CDM version to determine image.
- nodeSizeGb: System.Int32
  - Node disk size in GB.
- subnet: System.String
  - AWS subnet in which instance is created.
- vpc: System.String
  - The VPC of the AWS cluster.
- tags: System.String
  - Tags to attach to created resources.
- imageId: System.String
  - ID of the virtual machine image to deploy.
- instanceProfileName: System.String
  - Instance profile to attach to image.
- cdmProduct: System.String
  - AWS marketplace product ID.
- placementGroupName: System.String
  - Placement Group name.
- vmType: VmType
  - Create dense or standard nodes.
- securityGroups: list of System.Strings
  - List of security groups to assign to instances.
- instanceType: AwsInstanceType
  - AWS instance type.
- networkConfig: list of AwsVmNetworkConfigs
  - Network configuration for CDM nodes.
