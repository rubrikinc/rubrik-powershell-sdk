### AzureSubscriptionWithExoConfigs
Azure Cloud Account Subscription with exocompute configurations for feature configured.

- azureSubscriptionRubrikId: System.String
  - Rubrik ID for Azure subscription.
- azureSubscriptionNativeId: System.String
  - Native ID for Azure subscription.
- subscriptionName: System.String
  - Name of Azure subscription.
- featureDetail: AzureCloudAccountFeatureDetail
  - Feature details of subscription.
- mappedExocomputeSubscription: AzureMappedExocomputeSubscription
  - Mapped Exocompute subscription for launching Exocompute.
- mappedCloudAccountIds: list of System.Strings
  - Cloud Account IDs of subscriptions that are mapped to this Exocompute account.
- exocomputeConfigs: list of AzureExocomputeConfigDetailss
  - Exocompute configurations of the subscription.
- mappedExocomputeConfigs: list of AzureExocomputeConfigDetailss
  - Exocompute configurations available through mapped subscription.
- mappedCloudAccounts: list of CloudAccountDetailss
  - Cloud Account details of subscriptions that are mapped to this Exocompute account.
- globalConfig: AzureExocomputeOptionalConfigInRegion
  - Optional Exocompute configurations that apply to all the regions.
