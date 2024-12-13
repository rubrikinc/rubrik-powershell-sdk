### AdVolumeExportConnection
Paginated list of AdVolumeExport objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AdVolumeExportEdges
  - List of AdVolumeExport objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AdVolumeExports
  - List of AdVolumeExport objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AdVolumeExport objects matching the request arguments.
