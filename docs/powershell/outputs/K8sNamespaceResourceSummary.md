### K8sNamespaceResourceSummary
Per-namespace resource summary within a Kubernetes snapshot.

- namespace: System.String
  - Namespace name.
- totalCount: System.Int32
  - Total objects across all types in the namespace.
- types: list of K8sResourceTypeCounts
  - The per-object counts grouped by API group and resource type.
