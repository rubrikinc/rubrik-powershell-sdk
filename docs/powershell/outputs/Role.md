### Role
RBAC role.

- id: System.String
  - Role ID.
- name: System.String
  - Role name.
- description: System.String
  - Role description.
- isReadOnly: System.Boolean
  - Boolean value indicating if the role is read-only.
- protectableClusters: list of System.Strings
  - List of protectable Rubrik clusters.
- orgId: System.String
  - Role organization ID.
- isOrgAdmin: System.Boolean
  - If this role is a tenant organization administrator.
- permissions: list of Permissions
  - Role permissions.
- effectivePermissions: list of Permissions
  - Role permissions that are in effect.
- effectiveRbacPermissions: list of RbacPermissions
  - Permissions assigned to the role that are in effect.
- explicitlyAssignedPermissions: list of Permissions
  - Role permissions that are explicitly assigned by user.
- explicitProtectableClusters: list of System.Strings
  - Explicit list of protectable Rubrik clusters.
