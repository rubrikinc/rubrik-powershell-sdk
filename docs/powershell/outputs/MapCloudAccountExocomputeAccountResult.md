### MapCloudAccountExocomputeAccountResult
Per-account CloudFormation result for the KMS key sharing flow.

- applicationCloudAccountId: System.String
  - Application cloud account this result is for.
- cloudFormationUrl: System.String
  - CloudFormation URL the customer must approve.
- isPendingCftApproval: System.Boolean
  - Whether the mapping is awaiting CloudFormation approval.
- errorMessage: System.String
  - Error if this account failed; empty on success.
