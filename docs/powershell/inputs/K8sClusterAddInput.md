### K8sClusterAddInput
Supported in v9.0+
  Input to add a Kubernetes cluster.

- registry: System.String
  - Supported in v9.0+
      Container registry URL for storing Rubrik container images.
- distribution: System.String
  - Distribution of the Kubernetes cluster to be added.
- region: System.String
  - Region of the Kubernetes cluster to be added.
- kubeconfig: System.String
  - Required. Supported in v9.0+
      Kubeconfig is a YAML string to store Kubernetes cluster authentication information. You can get this config file directly from the cluster administrator or from a cloud platform if you are using managed Kubernetes cluster.
- name: System.String
  - Required. Supported in v9.0+
      Name of the Kubernetes cluster to be added.
