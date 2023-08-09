### K8sResourceSetSummary
Supported in v9.0+
  Key properties of a Kubernetes resource set.

- id: System.String
  - Required. Supported in v9.0+
  ID of the Kubernetes resource set.
- name: System.String
  - Required. Supported in v9.0+
  Name of the Kubernetes resource set.
- k8SClusterUuid: System.String
  - ID of the Kubernetes cluster to which the resource set belongs.
- k8SNamespace: System.String
  - Kubernetes namespace to which the resource set belongs.
- rsType: System.String
  - Required. Supported in v9.0+
  Type of the Kubernetes resource set.
- definition: System.String
  - Required. Supported in v9.0+
  Definition of the Kubernetes resource set.
- kubernetesNamespace: System.String
  - Kubernetes namespace to which the resource set belongs.
- kubernetesClusterUuid: System.String
  - ID of the Kubernetes cluster to which the resource set belongs.
- hookConfigs: list of System.Strings
  - 
