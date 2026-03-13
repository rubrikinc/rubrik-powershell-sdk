### AwsVmConfig
Configuration for creating AWS instances.

- cdmVersion: System.String
  - Rubrik CDM version to determine image. Should not be used if creating using image id.
This field can be an AWS CDM image version or "latest" if used with cdm_product.
- vmType: VmType
  - Create dense or standard nodes.
- nodeSizeGb: System.Int32
  - Node disk size in GB. Only needed for creating disk-based cluster.
- subnet: System.String
  - AWS subnet in which instance is created. To be deprecated. Ignored when AwsVmNetworkConfig is
specified.
- securityGroups: list of System.Strings
  - List of security groups to assign to instances.
- vpc: System.String
  - The VPC of the AWS cluster. Ignored when AwsVmNetworkConfig is specified.
- tags: System.String
  - Tags to attach to created resources (key=value separated by commas).
- imageId: System.String
  - ID of the virtual machine image to deploy. Should not be used if creating using marketplace
image (cdm_version field). If this field is used, cdm_version field will be ignored.
- instanceProfileName: System.String
  - Instance profile to attach to image.
- cdmProduct: System.String
  - AWS product listing to deploy. If no cdm_version is specified, it will pick the latest.
- instanceType: AwsInstanceType
  - AWS instance type.
- networkConfig: list of AwsVmNetworkConfigs
  - Network config per node. Has one entry per node.
- placementGroupName: System.String
  - Placement Group name.
- subnetAzConfigs: list of SubnetAzConfigInputs
  - List of subnet and availability zone pairs for Multi-AZ deployments.
Used when is_az_resilient is true.
