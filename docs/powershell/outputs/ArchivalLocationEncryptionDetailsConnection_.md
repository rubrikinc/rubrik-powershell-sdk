### ArchivalLocationEncryptionDetailsConnection
Paginated list of ArchivalLocationEncryptionDetails objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ArchivalLocationEncryptionDetailsEdges
  - List of ArchivalLocationEncryptionDetails objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ArchivalLocationEncryptionDetailss
  - List of ArchivalLocationEncryptionDetails objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ArchivalLocationEncryptionDetails objects matching the request arguments.
