### CdmGlobalConfigParamConnection
Paginated list of CdmGlobalConfigParam objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdmGlobalConfigParamEdges
  - List of CdmGlobalConfigParam objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdmGlobalConfigParams
  - List of CdmGlobalConfigParam objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CdmGlobalConfigParam objects matching the request arguments.
- lastSyncedTime: DateTime
  - Time the underlying configuration data was last synced from the cluster.
Surfaced on the connection as `lastSyncedTime`.
