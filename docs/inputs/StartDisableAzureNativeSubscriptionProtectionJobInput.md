### StartDisableAzureNativeSubscriptionProtectionJobInput
Input for the job to start disabling protection from the Azure Native Subscription.

- azureNativeProtectionFeature: AzureNativeProtectionFeature
  - Type of native protection to not be enabled.
- azureSubscriptionRubrikId: System.String
  - The Rubrik ID of the Azure subscription for which to disable protection.
- shouldDeleteNativeSnapshots: System.Boolean
  - Specifies whether to delete the snapshots associated with the subscription being deleted. When true, deletes the snapshots associated with the subscription being deleted.
