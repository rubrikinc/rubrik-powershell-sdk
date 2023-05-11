### AwsCloudAccountsWithFeaturesInput
AWS cloud accounts with features.

- awsAdminAccountFilter: System.String
  - Admin account ID to filter.
- columnSearchFilter: System.String
  - Search text to match in native ID, account name, and role ARN.
- feature: CloudAccountFeature
  - Type of cloud native protection feature.
- statusFilters: a list of CloudAccountStatuss
  - List of status filters for listing cloud accounts.
