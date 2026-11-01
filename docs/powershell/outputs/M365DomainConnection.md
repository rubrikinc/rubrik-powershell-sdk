### M365DomainConnection
Paginated list of M365Domain objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of M365DomainEdges
  - List of M365Domain objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of M365Domains
  - List of M365Domain objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of M365Domain objects matching the request arguments.
