### AwsFeatureConfig
AWS feature configurations in an AWS account.

- awsCloudAccount: AwsCloudAccount
  - Account details.
- featureDetail: FeatureDetail
  - Feature detail.
- exocomputeConfigs: list of AwsExocomputeGetConfigResponses
  - AWS Exocompute Configurations.
- exocomputeConfigurations: list of AwsExocomputeGetConfigurationResponses
  - AWS Exocompute Configurations.
- mappedExocomputeAccount: CloudAccountDetails
  - Account details of the mapped Exocompute account.
- roleChainingAccount: AwsRoleChainingAccount
  - Role chaining account details.
- exocomputeMappableRegions: list of AwsCloudAccountRegions
  - AWS regions that have protected objects.
- hasCloudDiscovery: System.Boolean
  - Indicates whether cloud discovery is enabled for this AWS account.
