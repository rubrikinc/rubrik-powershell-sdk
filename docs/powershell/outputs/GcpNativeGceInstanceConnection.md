### GcpNativeGceInstanceConnection
Paginated list of GcpNativeGceInstance objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of GcpNativeGceInstanceEdges
  - List of GcpNativeGceInstance objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of GcpNativeGceInstances
  - List of GcpNativeGceInstance objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of GcpNativeGceInstance objects matching the request arguments.
