### CustomTprPolicyConnection
Paginated list of CustomTprPolicy objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CustomTprPolicyEdges
  - List of CustomTprPolicy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CustomTprPolicys
  - List of CustomTprPolicy objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CustomTprPolicy objects matching the request arguments.
