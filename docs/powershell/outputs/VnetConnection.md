### VnetConnection
Paginated list of Vnet objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VnetEdges
  - List of Vnet objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Vnets
  - List of Vnet objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of Vnet objects matching the request arguments.
