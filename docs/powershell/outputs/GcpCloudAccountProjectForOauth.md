### GcpCloudAccountProjectForOauth
Details of a GCP project for OAuth.

- projectId: System.String
  - GCP project ID.
- name: System.String
  - GCP project name.
- missingPermissions: list of System.Strings
  - List of permissions missing in the GCP project.
- credentialsManagedBy: CredentialsManagedBy
  - CredentialsManagedBy specifies who manages the GCP credentials used for authentication and authorization when accessing GCP resources within the Rubrik platform.
