### AppItemChangeCountConnection
Paginated list of AppItemChangeCount objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AppItemChangeCountEdges
  - List of AppItemChangeCount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AppItemChangeCounts
  - List of AppItemChangeCount objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of AppItemChangeCount objects matching the request arguments.
