### O365TeamConversationsSenderConnection
Paginated list of O365TeamConversationsSender objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365TeamConversationsSenderEdges
  - List of O365TeamConversationsSender objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365TeamConversationsSenders
  - List of O365TeamConversationsSender objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365TeamConversationsSender objects matching the request arguments.
