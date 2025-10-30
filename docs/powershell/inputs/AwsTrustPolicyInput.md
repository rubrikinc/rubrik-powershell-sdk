### AwsTrustPolicyInput
Input to retrieve the AWS trust policy.

- cloudType: AwsCloudType
  - Type of the AWS cloud (Standard, Gov, etc.).
- features: list of CloudAccountFeatures
  - List of cloud account features.
- awsNativeAccounts: list of AwsNativeAccountInputs
  - IDs for the native AWS accounts.
- roleChainingAccountId: System.String
  - UUID of the account used for role chaining.
- persistRoleChainingMapping: System.Boolean
  - Flag to persist the existing role chaining mapping.
