### IdentityDataLocationEncryptionInfoConnection
Paginated list of IdentityDataLocationEncryptionInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of IdentityDataLocationEncryptionInfoEdges
  - List of IdentityDataLocationEncryptionInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of IdentityDataLocationEncryptionInfos
  - List of IdentityDataLocationEncryptionInfo objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of IdentityDataLocationEncryptionInfo objects matching the request arguments.
