### AdGpoMetadata
On-prem AD GPO-specific metadata. Populated only for GPO principal type.

- status: GpoStatusEnum
  - GPO enable/disable status (from gpo_flags).
- versionNumber: System.Int64
  - Raw version number from AD versionNumber attribute. uint64 (not uint32)
because AD packs two uint16 halves and serializes the result as a signed
Int32 --when the user-version half's high bit is set the value exceeds
INT32_MAX, which would overflow GraphQL's signed Int. uint64 maps to
Long! in the generated schema.
- userVersion: System.Int32
  - User settings version (high 16 bits of version_number). P1 field.
- computerVersion: System.Int32
  - Computer settings version (low 16 bits of version_number). P1 field.
- lastModified: System.Int64
  - Last modified timestamp in Unix epoch seconds.
- linkingStatus: GPOLinkingStatusEnum
  - GPO linking status (computed from OU gPLink). P1 field.
- fileSysPath: System.String
  - SYSVOL file path. P1 field.
- functionalityVersion: System.Int32
  - GPO schema version. P1 field.
- owners: list of PrincipalEntitys
  - List of GPO owners (typically domain admins or delegated users).
- editors: list of PrincipalEntitys
  - List of GPO editors (users/groups with edit permissions).
