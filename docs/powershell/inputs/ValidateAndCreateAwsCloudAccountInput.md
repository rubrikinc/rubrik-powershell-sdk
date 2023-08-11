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
