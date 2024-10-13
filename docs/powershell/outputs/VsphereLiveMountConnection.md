### VsphereLiveMountConnection
Paginated list of VsphereLiveMount objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VsphereLiveMountEdges
  - List of VsphereLiveMount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VsphereLiveMounts
  - List of VsphereLiveMount objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VsphereLiveMount objects matching the request arguments.
