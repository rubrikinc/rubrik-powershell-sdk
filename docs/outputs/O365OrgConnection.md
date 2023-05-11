### O365OrgConnection
Paginated list of O365Org objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of O365Org objects matching the request arguments.
- edges: a list of O365OrgEdges
  - List of O365Org objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of O365Orgs
  - List of O365Org objects.
- pageInfo: PageInfo
  - General information about this page of results.
