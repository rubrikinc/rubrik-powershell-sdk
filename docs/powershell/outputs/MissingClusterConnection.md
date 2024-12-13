### MissingClusterConnection
Paginated list of MissingCluster objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MissingClusterEdges
  - List of MissingCluster objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MissingClusters
  - List of MissingCluster objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of MissingCluster objects matching the request arguments.
