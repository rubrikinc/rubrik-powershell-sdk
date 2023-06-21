### K8sClusterInfo
Information of the Kubernetes cluster.

- kuprClusterUuid: System.String
  - UUID of the Kubernetes cluster.
- port: System.Int32
  - Port on the Kubernetes cluster used for communication with RSC.
- k8sVersion: System.String
  - Kubernetes version.
- type: K8sClusterType
  - Type of the Kubernetes cluster.
- associatedCdm: Cluster
  - Rubrik CDM cluster associated with the the Kubernetes cluster.
