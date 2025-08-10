### AwsCloudAccountsMigrateInitiateInput
Input to initiate cloud account migration to AWS organizations.

- orgId: System.String
  - The UUID of the AWS organization.
- awsRoleCustomization: AwsRoleCustomization
  - Role customization options.
- roleChainingAccountId: System.String
  - The UUID of the AWS account to be used for role chaining.
