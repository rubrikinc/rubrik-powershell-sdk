### RestoreK8sNamespaceInput
Configuration of the Kubernetes namespace snapshot to be restored and the target details.

- snapshotUuid: System.String
  - The UUID of the Kubernetes namespace snapshot to be restored.
- targetClusterUuid: System.String
  - The UUID of the target cluster to restore the namespace snapshot to.
- targetNamespaceName: System.String
  - The name of the target namespace to restore the namespace snapshot to.
- labelSelector: LabelSelector
  - Filters resources based on labels.
