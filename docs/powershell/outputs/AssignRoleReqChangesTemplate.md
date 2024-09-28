### AssignRoleReqChangesTemplate
TPR requested changes template for assigning TPR roles to users/groups.

- usersWithRoles: list of UserWithRoless
  - Users and their new role assignments.
- groupsWithRoles: list of UserGroupWithRoless
  - Groups and their new role assignments.
- oldRoles: list of RoleSummarys
  - Old roles on the users/groups.
- newRoles: list of RoleSummarys
  - New roles to assign to the users/groups.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
