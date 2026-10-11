### GcpPermissionGroup
Represents a GCP permission group.

- permissionGroupType: PermissionsGroup
  - The type of the permission group.
- policyVersion: System.Int32
  - Latest policy version of the permission group.
- permissionsWithoutConditions: list of System.Strings
  - Permissions required without condition to onboard the permission group.
- permissionsWithConditions: list of System.Strings
  - Permissions required with condition to onboard the permission group.
- conditions: list of System.Strings
  - IAM conditions restricting permissions_with_conditions to Rubrik-managed resources.
Multiple conditions are logically OR-ed together.
