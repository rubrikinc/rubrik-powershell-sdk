### VcdOrgLogicalChildTypeConnection
Paginated list of VcdOrgLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VcdOrgLogicalChildTypeEdges
  - List of VcdOrgLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VcdOrgLogicalChildTypes
  - List of VcdOrgLogicalChildType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VcdOrgLogicalChildType objects matching the request arguments.
