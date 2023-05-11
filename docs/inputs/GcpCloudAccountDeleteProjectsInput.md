### GcpCloudAccountDeleteProjectsInput
Input required to delete a list of GCP projects.

- cloudAccountsProjectIds: a list of System.Strings
  - List of project native IDs.
- nativeProtectionProjectIds: a list of System.Strings
  - List of GCP project native IDs to be added for native protection.
- sessionId: System.String
  - Session ID of the current OAuth session (optional).
- sharedVpcHostProjectIds: a list of System.Strings
  - List of GCP shared VPC host project native IDs.
- skipResourceDeletion: System.Boolean
  - Specifies whether cleanup of GCP resources should be skipped. If this flag is set, then the session ID is ignored.
