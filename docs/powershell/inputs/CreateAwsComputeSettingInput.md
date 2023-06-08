### CreateAwsComputeSettingInput
Cloud compute settings input for the AWS archival target.

- name: System.String
  - Name of the AWS cloud compute setting.
- subnetId: System.String
  - Subnet ID of the AWS target.
- vpcId: System.String
  - VPC ID of the AWS target.
- securityGroupId: System.String
  - Security Group ID of the AWS target.
- cloudAccountId: System.String
  - Cloud account ID of the AWS target.
- region: AwsRegion
  - AWS target region.
- isSecurityGroupPolarisManaged: System.Boolean
  - Specify if the security group is Rubrik SaaS Managed.
- clusterInterfaceCidrs: list of ClusterInfCidrsInputs
  - List of cluster interface CIDR.
