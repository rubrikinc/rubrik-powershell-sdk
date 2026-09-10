### UpgradeGcpCloudAccountPermissionsWithoutOauthInput
Input for upgrading GCP Cloud Account feature to connected state from update permissions without OAuth.

- cloudAccountId: System.String
  - Rubrik ID of the cloud account to upgrade permissions.
- feature: CloudAccountFeature
  - Feature enabled on the GCP Cloud Account, which is currently in Update Permissions state.
- featuresToUpgrade: list of FeatureWithPermissionsGroupss
  - Features with their permission groups to upgrade or install on the GCP cloud account, which are currently in the update permissions state.
