### K8sSnapshotResourceSummary
Compact summary of the Kubernetes resources captured in a snapshot: namespaces with per-type counts, plus cluster-scoped type counts.

- version: System.String
  - Version of the resource metadata format.
- namespaces: list of K8sNamespaceResourceSummarys
  - Per-namespace resource summaries.
- clusterScoped: list of K8sResourceTypeCounts
  - The cluster-scoped per-object counts grouped by API group and resource type.
