### LacpPresenceCheckConnection
Paginated list of LacpPresenceCheck objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of LacpPresenceCheckEdges
  - List of LacpPresenceCheck objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of LacpPresenceChecks
  - List of LacpPresenceCheck objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of LacpPresenceCheck objects matching the request arguments.
