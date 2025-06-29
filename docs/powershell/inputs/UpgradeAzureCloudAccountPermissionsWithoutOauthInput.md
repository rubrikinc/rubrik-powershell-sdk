### UpgradeAzureCloudAccountPermissionsWithoutOauthInput
Input for upgrading Azure Cloud Account feature to connected state from update permissions without OAuth.

- cloudAccountId: System.String
  - Rubrik ID of the cloud accounts to upgrade permissions.
- feature: CloudAccountFeature
  - Deprecated, use featureToUpgrade instead. Feature enabled on the Azure Cloud Account, which is currently in Update Permissions state.
- featureToUpgrade: list of UpgradeAzureCloudAccountFeatureInputs
  - Features enabled on the Azure Cloud Account, which are currently in the Update Permissions state.
- entraIdGroupId: System.String
  - Object ID of the Entra ID group to be used for Entra ID authentication in Exocompute. This field is optional, will only be updated if passed.
