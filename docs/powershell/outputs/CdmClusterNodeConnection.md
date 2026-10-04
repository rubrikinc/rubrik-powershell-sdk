### CdmClusterNodeConnection
Paginated list of CdmClusterNode objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdmClusterNodeEdges
  - List of CdmClusterNode objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdmClusterNodes
  - List of CdmClusterNode objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CdmClusterNode objects matching the request arguments.
