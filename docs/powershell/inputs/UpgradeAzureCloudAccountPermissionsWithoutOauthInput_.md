### UpgradeAzureCloudAccountPermissionsWithoutOauthInput
Input for upgrading Azure Cloud Account feature to connected state from update permissions without OAuth.

- cloudAccountId: System.String
  - Rubrik ID of the cloud accounts to upgrade permissions.
- feature: CloudAccountFeature
  - Deprecated, use featureToUpgrade instead. Feature enabled on the Azure Cloud Account, which is currently in Update Permissions state.
- featureToUpgrade: list of UpgradeAzureCloudAccountFeatureInputs
  - Features enabled on the Azure Cloud Account, which are currently in the Update Permissions state.
