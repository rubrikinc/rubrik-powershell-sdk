### K8sNamespaceConnection
Paginated list of K8sNamespace objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- aggregateK8sPvcs: System.Int32
  - The aggregate persistent volume claims (PVC) across namespaces based on applied filters and pagination arguments.
- aggregateK8sWorkloads: System.Int32
  - The aggregate workloads across namespaces based on applied filters and pagination arguments.
- count: System.Int32
  - Total number of K8sNamespace objects matching the request arguments.
- edges: a list of K8sNamespaceEdges
  - List of K8sNamespace objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of K8sNamespaces
  - List of K8sNamespace objects.
- pageInfo: PageInfo
  - General information about this page of results.
