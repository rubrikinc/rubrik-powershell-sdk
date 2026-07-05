### AzureDevOpsOrgInfo
Represents a single Azure DevOps organization the OAuth user has access to.

- name: System.String
  - Azure DevOps organization name (e.g., "my-org" from
https://dev.azure.com/my-org).
- orgId: System.String
  - Azure DevOps organization ID (organization UUID).
- orgUri: System.String
  - Azure DevOps organization URI (e.g., "https://dev.azure.com/my-org").
- isOnboarded: System.Boolean
  - True if this organization is already onboarded to Rubrik Security Cloud.
