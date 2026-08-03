### MapCloudAccountExocomputeAccountResult
Per-account CloudFormation result for the KMS key sharing flow.

- applicationCloudAccountId: System.String
  - Application cloud account this result is for.
- cloudFormationUrl: System.String
  - CloudFormation URL the customer must approve.
- isPendingApproval: System.Boolean
  - Whether the mapping is awaiting CloudFormation approval.
- errorMessage: System.String
  - Error if this account failed; empty on success.
- manualRolePolicyJson: System.String
  - Inline IAM policy the customer attaches to their existing cross-account
role to grant KMS key sharing. Set only for manually-onboarded accounts;
empty for CFT accounts, which use cloudFormationUrl instead.
