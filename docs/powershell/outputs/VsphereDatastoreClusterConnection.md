### VsphereDatastoreClusterConnection
Paginated list of VsphereDatastoreCluster objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VsphereDatastoreClusterEdges
  - List of VsphereDatastoreCluster objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VsphereDatastoreClusters
  - List of VsphereDatastoreCluster objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VsphereDatastoreCluster objects matching the request arguments.
