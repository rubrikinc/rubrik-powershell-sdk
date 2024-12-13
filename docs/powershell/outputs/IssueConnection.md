### IssueConnection
Paginated list of Issue objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of IssueEdges
  - List of Issue objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Issues
  - List of Issue objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of Issue objects matching the request arguments.
