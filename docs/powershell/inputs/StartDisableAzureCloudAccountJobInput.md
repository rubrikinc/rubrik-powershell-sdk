### StartDisableAzureCloudAccountJobInput
Input for starting jobs to disable a cloud account feature for a list of Azure Cloud Accounts.

- feature: CloudAccountFeature
  - Feature to not be enabled.
- cloudAccountIds: list of System.Strings
  - Rubrik IDs of the Cloud Accounts to not be enabled.
- sessionId: System.String
  - Session ID of the current OAuth session.
- deleteSnapshots: System.Boolean
  - Indicates whether managed snapshots should be deleted.
