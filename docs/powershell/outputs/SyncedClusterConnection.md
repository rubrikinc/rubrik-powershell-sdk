### SyncedClusterConnection
Paginated list of SyncedCluster objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SyncedClusterEdges
  - List of SyncedCluster objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SyncedClusters
  - List of SyncedCluster objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SyncedCluster objects matching the request arguments.