### AzureSubscriptionWithFeaturesType
Azure subscription with features.

- id: System.String
  - Azure subscription cloud account ID.
- cloudType: AzureCloudType
  - Cloud type of the Azure subscription.
- nativeId: System.String
  - Azure subscription native ID.
- name: System.String
  - Azure subscription native name.
- customerTenantId: System.String
  - Azure tenant ID.
- featureDetails: list of AzureCloudAccountFeatureDetails
  - Feature details for the cloud account.
- managementGroup: AzureManagementGroup
  - Management group of the Azure subscription.
- app: AzureCloudAccountTenantApp
  - The Azure application backing this subscription, together with the
authentication method it is bound to. Unset for a discovered subscription
that is not yet onboarded.
