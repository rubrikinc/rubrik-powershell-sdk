### VolumeGroupLiveMountConnection
Paginated list of VolumeGroupLiveMount objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of VolumeGroupLiveMount objects matching the request arguments.
- edges: a list of VolumeGroupLiveMountEdges
  - List of VolumeGroupLiveMount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of VolumeGroupLiveMounts
  - List of VolumeGroupLiveMount objects.
- pageInfo: PageInfo
  - General information about this page of results.
