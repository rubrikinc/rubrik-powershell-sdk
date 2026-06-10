### Permissions
Information about the permissions of a principal on targets.

- directPermissions: list of PermissionDetailss
  - direct_permissions lists permissions granted directly to the principal.
- permissionsByGroup: list of PermissionDetailss
  - permissions_by_group lists permissions granted through group membership.
- permissionsByRole: list of PermissionDetailss
  - permission_by_role lists permissions granted through roles.
- accessVia: PermissionsViaSummary
  - access_via summarizes how permissions are granted, either directly or
through roles/groups.
- evaluationResultRanks: list of System.Int32s
  - evaluation_result_ranks lists the ranks associated with the permissions.
