### AzureVmConfig
Azure Virtual Machine configuration parameters.

- resourceGroup: System.String
  - Virtual Machine resource group.
- cdmVersion: System.String
  - Cloud image CDM version.
- vmType: VmType
  - Standard or dense node.
- location: System.String
  - Virtual Machine location or region.
- nodeSizeGb: System.Int32
  - Node total attached disk capacity in GB.
- networkResourceGroup: System.String
  - Network resource group.
- vnetResourceGroup: System.String
  - VNet resource group.
- networkSecurityGroup: System.String
  - Network security group.
- networkSecurityResourceGroup: System.String
  - Resource group for network security group.
- vnet: System.String
  - Name of the Virtual Machine VNet.
- subnet: System.String
  - Name of the Virtual Machine subnet.
- tags: System.String
  - Tags attached to the Virtual Machine (key=value separated by commas).
- vmImage: System.String
  - Name of the Virtual Machine image to deploy. Should not be used if creating using marketplace
image (cdm_version field). If this field is used, cdm_version field will be ignored.
- cdmProduct: System.String
  - Name of CDM product. Should be used with 'cdm_version' field, previously product-sku
was used to determine latest cdm_version, but now both values are passed explicitly
so the backend can deploy the exact version specified by the UI.
- instanceType: AzureInstanceType
  - Azure instance type to be used for nodes.
- availabilityZone: System.String
  - Availability zone for CDM node placement.
- subnetAzConfigs: list of SubnetAzConfigInputs
  - List of subnet and availability zone pairs for Multi-AZ deployments.
Used when is_az_resilient is true.
