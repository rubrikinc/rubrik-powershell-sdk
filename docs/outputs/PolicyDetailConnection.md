### PolicyDetailConnection
Paginated list of PolicyDetail objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of PolicyDetail objects matching the request arguments.
- edges: a list of PolicyDetailEdges
  - List of PolicyDetail objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of PolicyDetails
  - List of PolicyDetail objects.
- pageInfo: PageInfo
  - General information about this page of results.
