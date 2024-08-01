### AzureNativeHierarchyObjectTypeConnection
Paginated list of AzureNativeHierarchyObjectType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureNativeHierarchyObjectTypeEdges
  - List of AzureNativeHierarchyObjectType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureNativeHierarchyObjectTypes
  - List of AzureNativeHierarchyObjectType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of AzureNativeHierarchyObjectType objects matching the request arguments.
