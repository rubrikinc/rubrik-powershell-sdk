### GcpCloudAccountAddManualAuthProjectInput
Input required to add a GCP cloud account manually.

- gcpNativeProjectId: System.String
  - The native project ID of the GCP project.
- gcpProjectName: System.String
  - The project name of the GCP project.
- gcpProjectNumber: System.Int64
  - The project number of the GCP project.
- organizationName: System.String
  - The name of the organization containing the project.
- serviceAccountJwtConfig: System.String
  - The JWT configuration of the service account.
- features: list of CloudAccountFeatures
  - Deprecated due to Permission Groups rollout, use featuresWithPermissionGroups.
- featuresWithPermissionGroups: list of FeatureWithPermissionsGroupss
  - Features with respective permission groups to be added to the account.
