### O365ConfiguredGroupMemberConnection
Paginated list of O365ConfiguredGroupMember objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365ConfiguredGroupMemberEdges
  - List of O365ConfiguredGroupMember objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365ConfiguredGroupMembers
  - List of O365ConfiguredGroupMember objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365ConfiguredGroupMember objects matching the request arguments.
