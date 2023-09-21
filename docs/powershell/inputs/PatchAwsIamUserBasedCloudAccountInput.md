### PatchAwsIamUserBasedCloudAccountInput
Input to update IAM user-based AWS cloud account.

- awsCloudAccountId: System.String
  - Rubrik ID for the AWS cloud account.
- feature: CloudAccountFeature
  - Native protection feature to be updated.
- awsRegions: AwsRegionsInput
  - List of AWS Regions.
- awsUserKeys: AwsUserKeysInput
  - AWS IAM user access/secret keys.
- awsRoleArn: AwsRoleArnInput
  - AWS role ARN for native protection.
- externalArtifactMap: list of ExternalArtifactss
  - Key value pair for external artifacts associated with an AWS account.
