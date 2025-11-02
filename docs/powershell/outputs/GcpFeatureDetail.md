### GcpFeatureDetail
GcpFeatureDetail represents the status and configuration details of a
specific feature within a GCP project.

- feature: CloudAccountFeature
  - The cloud account feature type that is enabled for the project,
such as CLOUD_NATIVE_PROTECTION, EXOCOMPUTE, or other supported features.
- status: CloudAccountStatus
  - Current operational status of the feature indicating whether it is
connected, disconnected, or in an error state.
- roleId: System.String
  - ID of the role created for this feature. This role will be used to
bind conditional permissions for the role and manage feature-specific
access control within the GCP project.
- enabledPermissionGroups: list of PermissionsGroups
  - Permission Groups enabled for the feature. Only populated if the feature
flag for permission groups is enabled.
