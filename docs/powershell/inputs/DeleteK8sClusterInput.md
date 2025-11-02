### DeleteK8sClusterInput
Input for deleting a Kubernetes cluster.

- id: System.String
  - Required. ID of the Kubernetes cluster to delete.
- forceDelete: System.Boolean
  - Flag to specify whether to delete the Kubernetes cluster even if it is not reachable. The default value is false.
- preserveSnapshots: System.Boolean
  - v9.0: Flag to specify whether to preserve snapshots of the Kubernetes resource sets in this cluster or to delete them. The default is to preserve the snapshots.
v9.1+: Flag to specify whether to preserve snapshots of the Kubernetes protection sets in this cluster or to delete them. The default is to preserve the snapshots.
