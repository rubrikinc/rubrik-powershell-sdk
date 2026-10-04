### CdmLocalConfigParamConnection
Paginated list of CdmLocalConfigParam objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdmLocalConfigParamEdges
  - List of CdmLocalConfigParam objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdmLocalConfigParams
  - List of CdmLocalConfigParam objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CdmLocalConfigParam objects matching the request arguments.
