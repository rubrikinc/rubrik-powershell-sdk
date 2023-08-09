### KubernetesResourceSetConnection
Paginated list of KubernetesResourceSet objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of KubernetesResourceSetEdges
  - List of KubernetesResourceSet objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of KubernetesResourceSets
  - List of KubernetesResourceSet objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of KubernetesResourceSet objects matching the request arguments.
