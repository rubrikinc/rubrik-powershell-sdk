### UpgradeAzureCloudAccountInput
Input for upgrading an Azure Cloud Account.

- sessionId: System.String
  - Session ID of the current OAuth session.
- features: list of CloudAccountFeatures
  - Deprecated, use subscriptionIdsWithFeaturesToUpgrade instead.Features enabled on the Azure Cloud Account.
- featuresToUpgrade: list of UpgradeAzureCloudAccountFeatureInputs
  - Deprecated, use subscriptionIdsWithFeaturesToUpgrade instead. Features enabled on the Azure Cloud Account.
- azureSubscriptionRubrikIds: list of System.Strings
  - Rubrik IDs of the subscriptions to be upgraded.
- subscriptionIdsWithFeaturesToUpgrade: list of SubscriptionIdWithFeaturesToUpgradeInputs
  - Map of subscription IDs to features to upgrade. This allows granular control over which features to upgrade for each subscription.
