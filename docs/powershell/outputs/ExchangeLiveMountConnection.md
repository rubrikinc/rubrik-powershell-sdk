### ExchangeLiveMountConnection
Paginated list of ExchangeLiveMount objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ExchangeLiveMountEdges
  - List of ExchangeLiveMount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ExchangeLiveMounts
  - List of ExchangeLiveMount objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ExchangeLiveMount objects matching the request arguments.
