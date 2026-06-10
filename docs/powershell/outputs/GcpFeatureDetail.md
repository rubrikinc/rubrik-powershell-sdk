### GcpFeatureDetail
Details of the Gcp Cloud Account feature.

- feature: CloudAccountFeature
  - The cloud account feature.
- status: CloudAccountStatus
  - Current operational status of the feature.
- roleId: System.String
  - ID of the role created for this feature.
- enabledPermissionGroups: list of PermissionsGroups
  - Permission Groups enabled for the feature.
- permissionsGroupVersions: list of PermissionsGroupWithVersions
  - Versioned permission groups for the feature, including each group's current policy version.
