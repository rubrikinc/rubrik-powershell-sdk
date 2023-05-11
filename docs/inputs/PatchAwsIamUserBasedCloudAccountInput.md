### PatchAwsIamUserBasedCloudAccountInput
Input to update IAM user-based AWS cloud account.

- awsCloudAccountId: System.String
  - Rubrik ID for the AWS cloud account.
- awsRegions: AwsRegionsInput
  - List of AWS Regions.
- awsRoleArn: AwsRoleArnInput
  - AWS role ARN for native protection.
- awsUserKeys: AwsUserKeysInput
  - AWS IAM user access/secret keys.
- feature: CloudAccountFeature
  - Native protection feature to be updated.
