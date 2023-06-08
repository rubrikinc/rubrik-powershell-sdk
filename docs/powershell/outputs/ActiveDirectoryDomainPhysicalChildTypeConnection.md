### ActiveDirectoryDomainPhysicalChildTypeConnection
Paginated list of ActiveDirectoryDomainPhysicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectoryDomainPhysicalChildTypeEdges
  - List of ActiveDirectoryDomainPhysicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectoryDomainPhysicalChildTypes
  - List of ActiveDirectoryDomainPhysicalChildType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ActiveDirectoryDomainPhysicalChildType objects matching the request arguments.
