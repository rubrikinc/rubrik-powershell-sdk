### DeleteAzureCloudAccountInput
Input for deleting an Azure Cloud Account.

- sessionId: System.String
  - Session ID of the current OAuth session.
- features: list of CloudAccountFeatures
  - Features enabled on the Azure Cloud Account.
- azureSubscriptionRubrikIds: list of System.Strings
  - Rubrik IDs of the subscriptions to be deleted.
