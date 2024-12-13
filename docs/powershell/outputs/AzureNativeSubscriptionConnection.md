### AzureNativeSubscriptionConnection
Paginated list of AzureNativeSubscription objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureNativeSubscriptionEdges
  - List of AzureNativeSubscription objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureNativeSubscriptions
  - List of AzureNativeSubscription objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureNativeSubscription objects matching the request arguments.
