### AwsComputeSettings
Compute setting for AWS Target.

- id: System.String
  - ID of the AWS cloud compute setting.
- subnetId: System.String
  - Subnet ID of the AWS target.
- vpcId: System.String
  - VPC ID of the AWS target.
- securityGroupId: System.String
  - Security Group ID of the AWS target.
- proxySettings: ProxySettings
  - Compute proxy settings of the AWS target.
- region: AwsRegion
  - AWS target region.
- name: System.String
  - Name of the AWS cloud compute setting.
- isArchived: System.Boolean
  - Specifies whether this AWS target is archived.
- clusterInterfaceCidrs: list of ClusterInfCidrss
  - List of cluster interface CIDR.
- cloudAccount: CloudAccount
  - Cloud account details of the AWS target.
- isRscManaged: System.Boolean
  - Managed by Rubrik SaaS.
