### AwsCloudAccountValidateInput
- features: list of CloudAccountFeatures
- awsAdminAccount: AwsCloudAccountAdminInput
- awsChildAccounts: list of AwsCloudAccountInputs
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - List of cloud account features with specific permissions groups. This list is a valid input only for customer-managed cluster users.
- awsIamPair: AwsIamPairInput
  - Details of IAM role to be used for data center role-based archival.
