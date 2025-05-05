### UpgradeAzureCloudAccountFeatureInput
Input to upgrade a feature for an Azure cloud account.

- featureType: CloudAccountFeature
  - Feature to be upgraded.
- permissionsGroups: list of PermissionsGroups
  - Specifies a list of permission groups for upgrading the feature. If the list is empty, existing permission groups are upgraded if they are available.
- resourceGroup: AddAzureCloudAccountResourceGroupInput
  - Specify a new resource group which will be created during the feature upgrade. However, this resource group will only be created if a mapping between the feature and the resource group does not already exist. Currently, this behavior is supported only for the AZURE_SQL_DB_PROTECTION feature.
