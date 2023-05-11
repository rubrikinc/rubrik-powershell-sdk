### AwsCloudAccountConfigsInput
Input to get AWS cloud account configurations.

- awsAdminAccountFilter: System.String
  - Admin account ID to filter.
- columnSearchFilter: System.String
  - Search text to match in native ID, account name, or role ARN.
- feature: CloudAccountFeature
  - Type of cloud native protection feature.
- statusFilters: a list of CloudAccountStatuss
  - List of status filters for listing cloud accounts.
