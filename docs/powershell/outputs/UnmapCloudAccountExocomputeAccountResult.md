### UnmapCloudAccountExocomputeAccountResult
Per-account CloudFormation result for the KMS key sharing revoke flow.

- applicationCloudAccountId: System.String
  - Application cloud account this result is for.
- cloudFormationUrl: System.String
  - CloudFormation URL the customer applies to revoke the KMS permissions.
- isPendingApproval: System.Boolean
  - Whether a revoke CFT was returned and the unmap is finalizing.
- errorMessage: System.String
  - Error if the revoke could not be initiated; unmap still completed.
- manualRolePolicyJson: System.String
  - Inline IAM policy the customer re-attaches to their cross-account role with
the KMS statements stripped. Set only for manually-onboarded accounts;
empty for CFT accounts, which use cloudFormationUrl instead.
- templateUrl: System.String
  - Raw S3 URL of the revoke CloudFormation template for download. Empty for
manual accounts.
