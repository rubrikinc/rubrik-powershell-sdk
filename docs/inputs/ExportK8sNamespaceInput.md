### ExportK8sNamespaceInput
Configuration of the Kubernetes namespace snapshot to be exported and the target details.

- labelSelector: LabelSelector
  - Filter resources based on labels.
- snapshotUuid: System.String
  - The UUID of the Kubernetes namespace snapshot to be exported.
- targetClusterUuid: System.String
  - The UUID of the target cluster to export the namespace snapshot to.
- targetNamespaceName: System.String
  - The name of the target namespace to export the namespace snapshot to.
