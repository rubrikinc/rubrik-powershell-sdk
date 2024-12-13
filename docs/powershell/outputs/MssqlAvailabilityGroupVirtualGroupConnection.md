### MssqlAvailabilityGroupVirtualGroupConnection
Paginated list of MssqlAvailabilityGroupVirtualGroup objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MssqlAvailabilityGroupVirtualGroupEdges
  - List of MssqlAvailabilityGroupVirtualGroup objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MssqlAvailabilityGroupVirtualGroups
  - List of MssqlAvailabilityGroupVirtualGroup objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of MssqlAvailabilityGroupVirtualGroup objects matching the request arguments.
