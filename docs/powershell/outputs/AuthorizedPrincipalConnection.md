### AuthorizedPrincipalConnection
Paginated list of AuthorizedPrincipal objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AuthorizedPrincipalEdges
  - List of AuthorizedPrincipal objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AuthorizedPrincipals
  - List of AuthorizedPrincipal objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of AuthorizedPrincipal objects matching the request arguments.
