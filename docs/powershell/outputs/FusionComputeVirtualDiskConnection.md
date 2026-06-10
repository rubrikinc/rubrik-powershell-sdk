### FusionComputeVirtualDiskConnection
Paginated list of FusionComputeVirtualDisk objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FusionComputeVirtualDiskEdges
  - List of FusionComputeVirtualDisk objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FusionComputeVirtualDisks
  - List of FusionComputeVirtualDisk objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FusionComputeVirtualDisk objects matching the request arguments.
