### GcpPermissionGroup
Represents a GCP permission group.

- policyVersion: System.Int32
  - Latest policy version of the permission group.
- permissionsWithoutConditions: list of System.Strings
  - Permissions required without condition to onboard the permission group.
- permissionsWithConditions: list of System.Strings
  - Permissions required with condition to onboard the permission group.
- permissionGroupType: PermissionsGroup
  - The type of the permission group.
