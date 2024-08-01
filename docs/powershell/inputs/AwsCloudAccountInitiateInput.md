### AwsCloudAccountInitiateInput
- action: CloudAccountAction
- features: list of CloudAccountFeatures
- awsAdminAccount: AwsCloudAccountInput
  - Admin account, required for bulk upload.
- awsChildAccounts: list of AwsCloudAccountInputs
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of cloud account features with specific permissions groups. This is a valid input only for customer-managed cluster users.
