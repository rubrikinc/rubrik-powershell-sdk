### AppAccessPrincipalConnection
Paginated list of AppAccessPrincipal objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AppAccessPrincipalEdges
  - List of AppAccessPrincipal objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AppAccessPrincipals
  - List of AppAccessPrincipal objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AppAccessPrincipal objects matching the request arguments.
