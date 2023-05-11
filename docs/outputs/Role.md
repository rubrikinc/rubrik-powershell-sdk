### Role
RBAC role.

- description: System.String
  - Role description.
- effectivePermissions: a list of Permissions
  - Role permissions that are in effect.
- explicitlyAssignedPermissions: a list of Permissions
  - Role permissions that are explicitly assigned by user.
- id: System.String
  - Role ID.
- isOrgAdmin: System.Boolean
  - If this role is a tenant organization administrator.
- isReadOnly: System.Boolean
  - Boolean value indicating if the role is read-only.
- name: System.String
  - Role name.
- orgId: System.String
  - Role organization ID.
- permissions: a list of Permissions
  - Role permissions.
- protectableClusters: a list of System.Strings
  - List of protectable Rubrik clusters.
