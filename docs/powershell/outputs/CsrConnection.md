### CsrConnection
Paginated list of Csr objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CsrEdges
  - List of Csr objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Csrs
  - List of Csr objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Csr objects matching the request arguments.
