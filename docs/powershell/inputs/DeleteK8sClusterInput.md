### DeleteK8sClusterInput
Input for deleting a Kubernetes cluster.

- id: System.String
  - Required. ID of the Kubernetes cluster to delete.
- forceDelete: System.Boolean
  - Flag to specify whether to delete the Kubernetes cluster even if it is not reachable. The default value is false.
- preserveSnapshots: System.Boolean
  - v9.0: Flag to specify whether to preserve snapshots of the Kubernetes resource sets in this cluster or to delete them. The default is to preserve the snapshots.
v9.1+: Flag to specify whether to preserve snapshots of the Kubernetes protection sets in this cluster or to delete them. The default is to preserve the snapshots.
- source: V1DeleteK8sClusterRequestSource
  - Origin of the delete request. When `helm`, the request originates from a helm uninstall pre-delete hook; CDM only archives database-side cluster state and leaves in-cluster kupr resource cleanup to helm. Defaults to `ui`.
