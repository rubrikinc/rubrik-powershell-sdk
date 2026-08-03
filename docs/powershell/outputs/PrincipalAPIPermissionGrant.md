### PrincipalAPIPermissionGrant
PrincipalAPIPermissionGrant describes an API permission granted to a principal.

- permission: System.String
  - The value of the permission itself, for example, "Sites.Read.All".
- isPrivileged: System.Boolean
  - Whether the permission is considered a privileged permission.
- creationDate: DateTime
  - The time when the permission was granted to the principal.
- identifier: System.String
  - The platform-provided ID of the permission grant.
