### FusionComputeHostConnection
Paginated list of FusionComputeHost objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FusionComputeHostEdges
  - List of FusionComputeHost objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FusionComputeHosts
  - List of FusionComputeHost objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FusionComputeHost objects matching the request arguments.
