### DeleteAzureDevOpsCloudAccountInput
Contains parameters to delete an existing Azure DevOps cloud account
configuration.

- organizationId: System.String
  - RSC-assigned UUID of the Azure DevOps organization to delete.
- deleteSnapshots: System.Boolean
  - Whether to delete all snapshots associated with this cloud account.
- sessionId: System.String
  - Session ID obtained from the startAzureCloudAccountOauth mutation. Use
the same session ID that was passed to completeAzureDevOpsOauth.
