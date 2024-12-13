### GcpCloudAccountUpgradeProjectsInput
Input required to upgrade a list of GCP projects.

- sessionId: System.String
  - Session ID of the current OAuth session.
- projectIds: list of System.Strings
  - List of GCP project IDs to be upgraded.
- feature: CloudAccountFeature
  - Cloud account feature. Either of this or featuresWithPermissionGroupsfield is required.
- featuresWithPermissionGroups: list of FeatureWithPermissionsGroupss
  - Features with respected permission groups to be upgraded.
