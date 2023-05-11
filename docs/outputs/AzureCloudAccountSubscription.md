### AzureCloudAccountSubscription
Azure Cloud Account Subscription for a given feature.

- cloudType: AzureCloudType
  - Cloud type of the Azure subscription.
- customerSubscriptionId: System.String
  - Cloud account ID of the subscription.
- customerTenantId: System.String
  - Rubrik ID of the Azure tenant in which this subscription is present.
- isAuthorized: System.Boolean
  - Specifies whether the requester has appropriate permissions on this subscription.
- name: System.String
  - Subscription name as specified in Azure.
- nativeId: System.String
  - Subscription UUID as specified in Azure.
