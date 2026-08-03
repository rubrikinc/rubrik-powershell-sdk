### PureStorageVolumeV1Connection
Paginated list of PureStorageVolumeV1 objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PureStorageVolumeV1Edges
  - List of PureStorageVolumeV1 objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PureStorageVolumeV1s
  - List of PureStorageVolumeV1 objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of PureStorageVolumeV1 objects matching the request arguments.
