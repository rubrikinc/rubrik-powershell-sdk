### GcpCloudAccountAddProjectsInput
Input required to add a GCP cloud account.

- sessionId: System.String
  - Session ID of the current OAuth session.
- nativeProtectionProjectIds: list of System.Strings
  - List of GCP project native IDs to be added for native protection.
- sharedVpcHostProjectIds: list of System.Strings
  - List of GCP shared VPC host project native IDs.
- cloudAccountsProjectIds: list of System.Strings
  - List of project native IDs.
- projectIds: list of System.Strings
  - List of project IDs.
- featuresWithPermissionGroups: list of FeatureWithPermissionsGroupss
  - Features with respective permission groups to be added.
