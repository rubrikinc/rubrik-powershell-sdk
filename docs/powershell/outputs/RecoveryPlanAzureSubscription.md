### RecoveryPlanAzureSubscription
Identifying details for an Azure subscription used as a recovery plan location.

- id: System.String
  - Identifier of the Azure subscription.
- name: System.String
  - Name of the Azure subscription.
- status: AzureSubscriptionStatus
  - Protection status of the Azure subscription.
- azureCloudType: AzureCloudType
  - Cloud partition the Azure subscription belongs to.
- regionSpecs: list of AzureNativeRegionSpecs
  - Region specifications configured for the Azure subscription.
