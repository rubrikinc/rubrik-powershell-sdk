### AwsExocomputeConfig
AWS Exocompute configurations in an AWS account.

- awsCloudAccount: AwsCloudAccount
  - Account details.
- featureDetail: FeatureDetail
  - Feature details.
- exocomputeEligibleRegions: list of AwsCloudAccountRegions
  - List of regions for which exocompute can be configured.
- configs: list of AwsExocomputeGetConfigResponses
  - AWS exocompute get configurations response.
- mappedCloudAccountIds: list of System.Strings
  - Cloud Accounts which are mapped to this Exocompute account.
