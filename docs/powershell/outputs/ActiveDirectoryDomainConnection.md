### ActiveDirectoryDomainConnection
Paginated list of ActiveDirectoryDomain objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectoryDomainEdges
  - List of ActiveDirectoryDomain objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectoryDomains
  - List of ActiveDirectoryDomain objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ActiveDirectoryDomain objects matching the request arguments.
