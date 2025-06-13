### AwsExocomputeConfig
AWS Exocompute configurations in an AWS account.

- awsCloudAccount: AwsCloudAccount
  - Account details.
- featureDetail: FeatureDetail
  - Feature details.
- exocomputeEligibleRegions: list of AwsCloudAccountRegions
  - List of regions for which Exocompute can be configured.
- configs: list of AwsExocomputeGetConfigResponses
  - AWS Exocompute get configurations response.
- exocomputeConfigs: list of AwsExocomputeGetConfigurationResponses
  - AWS Exocompute get configurations response.
- mappedCloudAccountIds: list of System.Strings
  - Cloud Accounts which are mapped to this Exocompute account.
- mappedCloudAccounts: list of CloudAccountDetailss
  - Details of cloud accounts which are mapped to this Exocompute account.
- mappedExocomputeConfigs: list of AwsExocomputeGetConfigurationResponses
  - AWS Exocompute configurations of the account to be used for Exocompute.
- roleChainingAccount: AwsRoleChainingAccount
  - Role chaining account details.
