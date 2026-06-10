### PathSecInfo
Security information for a single path.

- path: System.String
  - Path the security info applies to.
- owner: System.String
  - Owner of the path (resolved to a friendly name when possible).
- permissions: list of SDDLPermissions
  - Permissions granted on the path.
