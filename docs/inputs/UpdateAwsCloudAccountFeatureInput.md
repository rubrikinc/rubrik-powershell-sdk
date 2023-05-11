### UpdateAwsCloudAccountFeatureInput
Input to update an AWS account.

- action: CloudAccountAction
  - Action to be taken for cloud account update.
- awsAccountName: System.String
  - AWS account name.
- awsRegions: a list of AwsCloudAccountRegions
  - List of regions to be added.
- cloudAccountId: System.String
  - Rubrik ID of the AWS account.
- feature: CloudAccountFeature
  - Native protection feature to be updated.
- roleArn: System.String
  - Role ARN for the cloud account.
- stackArn: System.String
  - Stack ARN for the cloud account.
