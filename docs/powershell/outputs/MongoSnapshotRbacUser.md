### MongoSnapshotRbacUser
Supported in v9.6+
A MongoDB user account captured in a snapshot of the admin database, along with the roles granted to the account.

- db: System.String
  - Required. Supported in v9.6+
Name of the authentication database of the user account.
- user: System.String
  - Required. Supported in v9.6+
Name of the MongoDB user account.
- roles: list of MongoSnapshotRbacRoleAssignments
  - Supported in v9.6+
Roles granted to the user account. Empty if the account has no roles, or if the Rubrik cluster was configured not to record role assignments when the snapshot was taken.
