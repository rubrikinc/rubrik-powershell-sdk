### AwsCloudAccountInput
Details of an AWS cloud account.

- id: System.String
  - Rubrik ID of the AWS cloud account.
- nativeId: System.String
  - Native ID of cloud account.
- accountName: System.String
  - Name of cloud account.
- seamlessFlowEnabled: System.Boolean
  - Whether seamless setup flow is enabled on cloud account.
- orgName: System.String
  - The AWS organization name with which you onboarded the AWS account.
- outpostAwsNativeId: System.String
  - AWS Outpost account native ID uniquely identifies and manages specific Outpost resources within AWS.
- orgId: System.String
  - The UUID of the onboarded AWS organization.
- cloudType: AwsCloudType
  - Cloud type (Standard/China) for the cloud account.
