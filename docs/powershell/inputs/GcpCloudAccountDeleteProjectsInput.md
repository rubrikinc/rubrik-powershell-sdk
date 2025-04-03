### GcpCloudAccountDeleteProjectsInput
Input required to delete a list of GCP projects.

- sessionId: System.String
  - Session ID of the current OAuth session (optional).
- nativeProtectionProjectIds: list of System.Strings
  - List of GCP project native IDs to be added for native protection.
- sharedVpcHostProjectIds: list of System.Strings
  - List of GCP shared VPC host project native IDs.
- cloudAccountsProjectIds: list of System.Strings
  - List of project native IDs.
- skipResourceDeletion: System.Boolean
  - Specifies whether cleanup of GCP resources should be skipped. If this flag is set, then the session ID is ignored.
- projectIds: list of System.Strings
  - List of project IDs.
- features: list of CloudAccountFeatures
  - List of cloud account features.
