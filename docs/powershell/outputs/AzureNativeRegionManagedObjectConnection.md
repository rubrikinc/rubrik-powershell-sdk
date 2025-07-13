### AzureNativeRegionManagedObjectConnection
Paginated list of AzureNativeRegionManagedObject objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureNativeRegionManagedObjectEdges
  - List of AzureNativeRegionManagedObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureNativeRegionManagedObjects
  - List of AzureNativeRegionManagedObject objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureNativeRegionManagedObject objects matching the request arguments.
