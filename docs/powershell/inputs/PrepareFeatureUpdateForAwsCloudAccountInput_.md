### PrepareFeatureUpdateForAwsCloudAccountInput
Input to prepare feature update for AWS cloud account.

- cloudAccountId: System.String
  - AWS account ID.
- features: list of CloudAccountFeatures
  - List of cloud account features.
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of features to be updated for the AWS account with specific permissions groups. This list is a valid input only for customer-managed cluster users.
- awsRoleCustomization: AwsRoleCustomization
  - Role customization options.
- awsIamPairId: System.String
  - Internal ID of the IAM pair. This field is required only when the feature to be updated is DATA_CENTER_ROLE_BASED_ARCHIVAL.
