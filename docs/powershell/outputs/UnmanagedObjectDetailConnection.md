### UnmanagedObjectDetailConnection
Paginated list of UnmanagedObjectDetail objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of UnmanagedObjectDetailEdges
  - List of UnmanagedObjectDetail objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of UnmanagedObjectDetails
  - List of UnmanagedObjectDetail objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of UnmanagedObjectDetail objects matching the request arguments.
