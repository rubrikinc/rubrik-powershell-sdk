### ExchangeDagDescendantTypeConnection
Paginated list of ExchangeDagDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of ExchangeDagDescendantType objects matching the request arguments.
- edges: a list of ExchangeDagDescendantTypeEdges
  - List of ExchangeDagDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of ExchangeDagDescendantTypes
  - List of ExchangeDagDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
