### O365SharepointDriveConnection
Paginated list of O365SharepointDrive objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365SharepointDriveEdges
  - List of O365SharepointDrive objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365SharepointDrives
  - List of O365SharepointDrive objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of O365SharepointDrive objects matching the request arguments.
