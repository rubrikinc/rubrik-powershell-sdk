### AwsVmConfig
Configuration for creating AWS instances.

- cdmProduct: System.String
  - AWS marketplace product ID.
- cdmVersion: System.String
  - Rubrik CDM version to determine image.
- imageId: System.String
  - ID of the virtual machine image to deploy.
- instanceProfileName: System.String
  - Instance profile to attach to image.
- nodeSizeGb: System.Int32
  - Node disk size in GB.
- securityGroups: a list of System.Strings
  - List of security groups to assign to instances.
- subnet: System.String
  - AWS subnet in which instance is created.
- tags: System.String
  - Tags to attach to created resources.
- vmType: VmType
  - Create dense or standard nodes.
