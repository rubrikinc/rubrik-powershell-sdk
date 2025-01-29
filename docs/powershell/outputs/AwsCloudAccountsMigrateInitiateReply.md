### AwsCloudAccountsMigrateInitiateReply
Generate CFT for migrating the existing AWS cloud accounts to AWS organizations.

- templateUrl: System.String
  - Link to download the CFT.
- stackName: System.String
  - Stack name of the stack which will be used for managing organization-based accounts.
- cloudFormationUrl: System.String
  - This URL is used to create the CloudFormation stack for managing organization-based accounts.
- eligibleAwsAccounts: list of AwsCloudAccounts
  - List of AWS accounts which will be migrated to organization-based flow.
