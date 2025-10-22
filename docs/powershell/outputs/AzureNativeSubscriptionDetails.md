### AzureNativeSubscriptionDetails
Azure native subscription details.

- id: System.String
  - The unique identifier for the Azure subscription.
- name: System.String
  - The name of the Azure subscription.
- nativeId: System.String
  - The native identifier for the Azure subscription.
- status: AzureSubscriptionStatus
  - The current status of the Azure subscription.
- tenantId: System.String
  - The tenant identifier for the Azure subscription.
- cloudType: AzureCloudType
  - The cloud type for the Azure subscription.
- accountConnectionId: System.String
  - The account connection identifier for the Azure subscription.
- regionSpecs: list of AzureNativeRegionSpecs
  - The region specifications for the Azure subscription.
- enabledFeatures: list of AzureNativeSubscriptionEnabledFeatures
  - Details of features enabled for the subscription.
