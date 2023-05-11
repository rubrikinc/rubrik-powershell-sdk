### CreateAwsComputeSettingInput
Cloud compute settings input for the AWS archival target.

- cloudAccountId: System.String
  - Cloud account ID of the AWS target.
- clusterInterfaceCidrs: a list of ClusterInfCidrsInputs
  - List of cluster interface CIDR.
- isSecurityGroupPolarisManaged: System.Boolean
  - Specify if the security group is Rubrik SaaS Managed.
- name: System.String
  - Name of the AWS cloud compute setting.
- region: AwsRegion
  - AWS target region.
- securityGroupId: System.String
  - Security Group ID of the AWS target.
- subnetId: System.String
  - Subnet ID of the AWS target.
- vpcId: System.String
  - VPC ID of the AWS target.
