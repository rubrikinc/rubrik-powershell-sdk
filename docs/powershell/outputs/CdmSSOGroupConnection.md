### CdmSSOGroupConnection
Paginated list of CdmSSOGroup objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdmSSOGroupEdges
  - List of CdmSSOGroup objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdmSSOGroups
  - List of CdmSSOGroup objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of CdmSSOGroup objects matching the request arguments.
