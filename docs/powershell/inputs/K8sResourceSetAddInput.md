### K8sResourceSetAddInput
Supported in v9.0+
  Input to add a Kubernetes resource set.

- k8SClusterUuid: System.String
  - ID of the Kubernetes cluster to which the resource set to be added belongs.
- k8SNamespace: System.String
  - Kubernetes namespace to which the resource set to be added belongs.
- kubernetesNamespace: System.String
  - Kubernetes namespace to which the resource set to be added belongs.
- kubernetesClusterUuid: System.String
  - ID of the Kubernetes cluster to which the resource set to be added belongs.
- hookConfigs: list of System.Strings
  - 
- definition: System.String
  - Required. Supported in v9.0+
      Definition of the Kubernetes resource set to be added.
- name: System.String
  - Required. Supported in v9.0+
      Name of the Kubernetes resource set to be added.
- rsType: System.String
  - Required. Supported in v9.0+
      Type of the Kubernetes resource set to be added.
