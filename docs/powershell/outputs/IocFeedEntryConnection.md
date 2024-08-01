### IocFeedEntryConnection
Paginated list of IocFeedEntry objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of IocFeedEntryEdges
  - List of IocFeedEntry objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of IocFeedEntrys
  - List of IocFeedEntry objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of IocFeedEntry objects matching the request arguments.
