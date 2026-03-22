### AzureManagementGroup
AzureManagementGroup is a representation of the native Azure management group.

- nativeId: System.String
  - Azure Native ID of the management group.
- name: System.String
  - Display name of the management group.
- isAuthorized: System.Boolean
  - Whether Rubrik can onboard this management group (output-only,
not present in input type).
- customerManagementGroupId: System.String
  - Rubrik customer management group ID (output-only UUID).
