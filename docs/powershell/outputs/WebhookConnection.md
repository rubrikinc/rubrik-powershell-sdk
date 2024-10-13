### WebhookConnection
Paginated list of Webhook objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of WebhookEdges
  - List of Webhook objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Webhooks
  - List of Webhook objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Webhook objects matching the request arguments.
