### O365SharepointListConnection
Paginated list of O365SharepointList objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365SharepointListEdges
  - List of O365SharepointList objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365SharepointLists
  - List of O365SharepointList objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of O365SharepointList objects matching the request arguments.
