### UpgradeAzureCloudAccountInput
Input for upgrading an Azure Cloud Account.

- sessionId: System.String
  - Session ID of the current OAuth session.
- features: list of CloudAccountFeatures
  - Deprecated, use featuresToUpgrade instead. Features enabled on the Azure Cloud Account.
- featuresToUpgrade: list of UpgradeAzureCloudAccountFeatureInputs
  - Features enabled on the Azure Cloud Account.
- azureSubscriptionRubrikIds: list of System.Strings
  - Rubrik IDs of the subscriptions to be upgraded.
