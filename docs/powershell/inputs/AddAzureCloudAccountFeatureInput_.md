### AddAzureCloudAccountFeatureInput
Input for enabling a feature for an Azure cloud account.

- resourceGroup: AddAzureCloudAccountResourceGroupInput
  - Resource group to be used for creating all the resources for the feature. It is required only for the Cloud Native Archival feature. It will be ignored for other features.
- featureType: CloudAccountFeature
  - Feature to be enabled.
- permissionsGroups: list of PermissionsGroups
  - Specifies a list of permission groups for onboarding the feature. If the list is empty, all permission groups will be onboarded.
