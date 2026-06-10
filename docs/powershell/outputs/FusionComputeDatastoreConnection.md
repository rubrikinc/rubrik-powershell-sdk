### FusionComputeDatastoreConnection
Paginated list of FusionComputeDatastore objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FusionComputeDatastoreEdges
  - List of FusionComputeDatastore objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FusionComputeDatastores
  - List of FusionComputeDatastore objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FusionComputeDatastore objects matching the request arguments.
