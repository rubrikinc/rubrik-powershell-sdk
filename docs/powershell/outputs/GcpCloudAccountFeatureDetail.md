### GcpCloudAccountFeatureDetail
Details of the Gcp Cloud Account feature.

- feature: CloudAccountFeature
  - The cloud account feature.
- status: CloudAccountStatus
  - Specifies the status of the cloud account.
- roleId: System.String
  - Specifies the ID of the feature-specific role, if it exists.
- enabledPermissionGroups: list of PermissionsGroups
  - Permission Groups enabled for the feature. Only populated if the feature flag for permission groups is enabled.
