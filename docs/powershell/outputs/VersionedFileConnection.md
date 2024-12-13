### VersionedFileConnection
Paginated list of VersionedFile objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VersionedFileEdges
  - List of VersionedFile objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VersionedFiles
  - List of VersionedFile objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of VersionedFile objects matching the request arguments.
