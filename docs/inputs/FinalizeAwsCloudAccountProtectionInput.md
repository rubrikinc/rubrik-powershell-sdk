### FinalizeAwsCloudAccountProtectionInput
Input to finalize set up of an AWS cloud account.

- action: CloudAccountAction
  - Action to be performed with cloud account.
- awsAdminAccount: AwsCloudAccountInput
  - Admin account, required for bulk upload.
- awsChildAccounts: a list of AwsCloudAccountInputs
  - List of AWS accounts.
- awsRegions: a list of AwsCloudAccountRegions
  - List of AWS regions for the cloud account.
- externalId: System.String
  - External ID of the IAM role trust policy for the cloud account.
- featureVersion: a list of AwsCloudAccountFeatureVersionInputs
  - List of feature types to be protected for the cloud account.
- features: a list of CloudAccountFeatures
  - List of features for native protection of cloud account.
- stackName: System.String
  - Name of the CloudFormation stack to be created.
- stackSetName: System.String
  - Stackset name of the CloudFormation stack to be created.
