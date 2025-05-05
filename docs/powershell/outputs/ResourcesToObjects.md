### ResourcesToObjects
Map of resource type to Kubernetes objects.

- resources: System.String
  - The resource type of Kubernetes resource objects in the snapshot.
- value: list of K8sObjectss
  - Kubernetes objects in the snapshot. Namespace-scoped objects are grouped by namespace.
