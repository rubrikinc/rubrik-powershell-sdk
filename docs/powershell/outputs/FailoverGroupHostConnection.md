### FailoverGroupHostConnection
Paginated list of FailoverGroupHost objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FailoverGroupHostEdges
  - List of FailoverGroupHost objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FailoverGroupHosts
  - List of FailoverGroupHost objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FailoverGroupHost objects matching the request arguments.
