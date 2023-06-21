### NasNamespaceDescendantTypeConnection
Paginated list of NasNamespaceDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NasNamespaceDescendantTypeEdges
  - List of NasNamespaceDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NasNamespaceDescendantTypes
  - List of NasNamespaceDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of NasNamespaceDescendantType objects matching the request arguments.
