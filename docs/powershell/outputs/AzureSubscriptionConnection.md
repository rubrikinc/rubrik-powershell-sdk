### AzureSubscriptionConnection
Paginated list of AzureSubscription objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureSubscriptionEdges
  - List of AzureSubscription objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureSubscriptions
  - List of AzureSubscription objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureSubscription objects matching the request arguments.
