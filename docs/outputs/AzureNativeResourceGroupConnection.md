### AzureNativeResourceGroupConnection
Paginated list of AzureNativeResourceGroup objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of AzureNativeResourceGroup objects matching the request arguments.
- edges: a list of AzureNativeResourceGroupEdges
  - List of AzureNativeResourceGroup objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of AzureNativeResourceGroups
  - List of AzureNativeResourceGroup objects.
- pageInfo: PageInfo
  - General information about this page of results.
