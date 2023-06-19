### MssqlLogShippingTargetConnection
Paginated list of MssqlLogShippingTarget objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MssqlLogShippingTargetEdges
  - List of MssqlLogShippingTarget objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MssqlLogShippingTargets
  - List of MssqlLogShippingTarget objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of MssqlLogShippingTarget objects matching the request arguments.
