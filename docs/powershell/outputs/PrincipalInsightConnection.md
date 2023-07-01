### PrincipalInsightConnection
Paginated list of PrincipalInsight objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PrincipalInsightEdges
  - List of PrincipalInsight objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PrincipalInsights
  - List of PrincipalInsight objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of PrincipalInsight objects matching the request arguments.
