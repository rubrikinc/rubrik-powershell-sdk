### AwsCloudAccount
Details of AWS account.

- id: System.String
  - Rubrik ID of cloud account.
- nativeId: System.String
  - Native ID of cloud account.
- accountName: System.String
  - Name of cloud account.
- message: System.String
  - Message for cloud account, in case of error.
- seamlessFlowEnabled: System.Boolean
  - Whether seamless flow is enabled on cloud account.
- cloudType: AwsCloudType
  - Type of cloud account.
- orgName: System.String
  - The AWS organization name with which you onboarded the AWS account.
- outpostAwsNativeId: System.String
  - Native ID of the AWS Outpost account.
- orgId: System.String
  - The UUID of the onboarded AWS organization.
- serviceType: AwsCloudAccountServiceType
  - Service type indicating whether the account is onboarded for BaaS or
non-BaaS use case.
- crossAccountRoleModel: CrossAccountRoleModel
  - Cross-account role model: SINGLE_ROLE or MULTI_ROLE.
