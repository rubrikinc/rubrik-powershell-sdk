### O365AdGroupMemberConnection
Paginated list of O365AdGroupMember objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365AdGroupMemberEdges
  - List of O365AdGroupMember objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365AdGroupMembers
  - List of O365AdGroupMember objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365AdGroupMember objects matching the request arguments.
