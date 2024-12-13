### AzureNativeResourceGroupConnection
Paginated list of AzureNativeResourceGroup objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureNativeResourceGroupEdges
  - List of AzureNativeResourceGroup objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureNativeResourceGroups
  - List of AzureNativeResourceGroup objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureNativeResourceGroup objects matching the request arguments.
