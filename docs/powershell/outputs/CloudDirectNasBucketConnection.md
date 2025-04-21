### CloudDirectNasBucketConnection
Paginated list of CloudDirectNasBucket objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CloudDirectNasBucketEdges
  - List of CloudDirectNasBucket objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CloudDirectNasBuckets
  - List of CloudDirectNasBucket objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CloudDirectNasBucket objects matching the request arguments.
