### AzureCloudAccountSubscriptionDetail
Azure Cloud Account Subscription details for a given feature.

- id: System.String
  - Rubrik ID of the Azure Subscription.
- nativeId: System.String
  - Subscription UUID as specified in Azure.
- name: System.String
  - Subscription name as specified in Azure.
- featureDetail: AzureCloudAccountFeatureDetail
  - One of the enabled features on this subscription.
