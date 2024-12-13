### M365BackupStorageRestorePointConnection
Paginated list of M365BackupStorageRestorePoint objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of M365BackupStorageRestorePointEdges
  - List of M365BackupStorageRestorePoint objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of M365BackupStorageRestorePoints
  - List of M365BackupStorageRestorePoint objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of M365BackupStorageRestorePoint objects matching the request arguments.
