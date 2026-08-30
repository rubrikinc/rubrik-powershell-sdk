### AwsCloudAccount
Details of the AWS account.

- id: System.String
  - Rubrik ID of the cloud account.
- nativeId: System.String
  - Native ID of the cloud account.
- accountName: System.String
  - Name of the cloud account.
- message: System.String
  - Message for the cloud account, in case of an error.
- seamlessFlowEnabled: System.Boolean
  - Whether seamless flow is enabled on the cloud account.
- cloudType: AwsCloudType
  - Type of the cloud account.
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
