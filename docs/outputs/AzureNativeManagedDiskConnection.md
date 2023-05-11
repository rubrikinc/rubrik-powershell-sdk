### AzureNativeManagedDiskConnection
Paginated list of AzureNativeManagedDisk objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of AzureNativeManagedDisk objects matching the request arguments.
- edges: a list of AzureNativeManagedDiskEdges
  - List of AzureNativeManagedDisk objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of AzureNativeManagedDisks
  - List of AzureNativeManagedDisk objects.
- pageInfo: PageInfo
  - General information about this page of results.
