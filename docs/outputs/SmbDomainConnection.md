### SmbDomainConnection
Paginated list of SmbDomain objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of SmbDomain objects matching the request arguments.
- edges: a list of SmbDomainEdges
  - List of SmbDomain objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of SmbDomains
  - List of SmbDomain objects.
- pageInfo: PageInfo
  - General information about this page of results.
