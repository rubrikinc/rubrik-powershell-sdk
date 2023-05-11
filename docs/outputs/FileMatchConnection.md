### FileMatchConnection
Paginated list of FileMatch objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of FileMatch objects matching the request arguments.
- edges: a list of FileMatchEdges
  - List of FileMatch objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of FileMatchs
  - List of FileMatch objects.
- pageInfo: PageInfo
  - General information about this page of results.
