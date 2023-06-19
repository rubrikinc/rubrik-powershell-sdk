### O365TeamsChannelConnection
Paginated list of O365TeamsChannel objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365TeamsChannelEdges
  - List of O365TeamsChannel objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365TeamsChannels
  - List of O365TeamsChannel objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365TeamsChannel objects matching the request arguments.
