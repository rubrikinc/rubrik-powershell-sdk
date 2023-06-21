### UpdateAwsCloudAccountFeatureInput
Input to update an AWS account.

- cloudAccountId: System.String
  - Rubrik ID of the AWS account.
- action: CloudAccountAction
  - Action to be taken for cloud account update.
- feature: CloudAccountFeature
  - Native protection feature to be updated.
- awsRegions: list of AwsCloudAccountRegions
  - List of regions to be added.
- roleArn: System.String
  - Role ARN for the cloud account.
- stackArn: System.String
  - Stack ARN for the cloud account.
- awsAccountName: System.String
  - AWS account name.
