### DeleteK8sClusterInput


- preserveSnapshots: System.Boolean
  - v9.0: Flag to specify whether to preserve snapshots of the Kubernetes resource sets in this cluster or to delete them. The default is to preserve the snapshots.
      v9.1+: Flag to specify whether to preserve snapshots of the Kubernetes protection sets in this cluster or to delete them. The default is to preserve the snapshots.
- id: System.String
  - Required. ID of the Kubernetes cluster to delete.
