### ValidateAndCreateAwsCloudAccountInput
Input to validate and set up an AWS account.

- action: CloudAccountAction
  - Action to be performed with the cloud account.
- features: list of CloudAccountFeatures
  - List of features to be enabled for cloud native protection.
- awsAdminAccount: AwsCloudAccountInput
  - Admin account, required for bulk upload.
- awsChildAccounts: list of AwsCloudAccountInputs
  - Details for cloud accounts to be initiated.
- awsRoleCustomization: AwsRoleCustomization
  - Role customization options.
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of cloud account features with specific permissions groups to onboard. This list is a valid input only for customer-managed cluster users.
- awsIamPair: AwsIamPairInput
  - Details of IAM role to be used for data center role-based archival.
