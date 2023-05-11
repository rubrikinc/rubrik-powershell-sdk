### O365SiteConnection
Paginated list of O365Site objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of O365Site objects matching the request arguments.
- edges: a list of O365SiteEdges
  - List of O365Site objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of O365Sites
  - List of O365Site objects.
- pageInfo: PageInfo
  - General information about this page of results.
