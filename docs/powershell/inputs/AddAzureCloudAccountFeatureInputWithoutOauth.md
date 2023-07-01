### AddAzureCloudAccountFeatureInputWithoutOauth
Input for enabling a feature for an Azure cloud account without oauth.

- policyVersion: System.Int32
  - Version of the Azure role policy.
- resourceGroup: AddAzureCloudAccountResourceGroupInput
  - Resource group to be used for creating all the resources for the feature. Resource group is required only for the Cloud Native Archival/Archival-Encryption features. It will be ignored for other features.
- specificFeatureInput: AddAzureCloudAccountSpecificFeatureInput
  - Specific feature input to be used for enabling the feature. It is required only for the Cloud Native Archival Encryption feature. It will be ignored for other features.
- featureType: CloudAccountFeature
  - Feature to be enabled.
- permissionsGroups: list of PermissionsGroups
  - Specifies a list of permission groups for onboarding the feature. If the list is empty, all permission groups will be onboarded.
