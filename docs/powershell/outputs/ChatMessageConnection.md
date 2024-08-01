### ChatMessageConnection
Paginated list of ChatMessage objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ChatMessageEdges
  - List of ChatMessage objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ChatMessages
  - List of ChatMessage objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ChatMessage objects matching the request arguments.
