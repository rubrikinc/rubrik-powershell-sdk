### AwsCloudAccountsWithFeaturesInput
AWS cloud accounts with features.

- feature: CloudAccountFeature
  - Include only AWS accounts that have this feature enabled.
- statusFilters: list of CloudAccountStatuss
  - List of status filters for listing cloud accounts.
- awsAdminAccountFilter: System.String
  - Admin account ID to filter.
- columnSearchFilter: System.String
  - Search text to match in native ID, account name, and role ARN.
- featuresToFilterOut: list of CloudAccountFeatures
  - Exclude AWS accounts that have any of these features enabled.
- operation: Operation
  - Filter by the operation defined in the RBAC system.
