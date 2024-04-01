### K8sClusterAddInput
Supported in v9.0+
  Input to add a Kubernetes cluster.

- id: System.String
  - Supported in v9.1+
      UUID of the to be added Kubernetes cluster.
- kubeconfig: System.String
  - Supported in v9.0+
      Kubeconfig is a YAML string to store Kubernetes cluster authentication information. You can get this config file directly from the cluster administrator or from a cloud platform if you are using managed Kubernetes cluster.
- registry: System.String
  - Supported in v9.0+
      Container registry URL for storing Rubrik container images.
- serviceAccountName: System.String
  - Supported in v9.1+
      The name of the RSC service account.
- eksConfig: EksConfigInput
  - The configuration for adding an EKS cluster.
- distribution: System.String
  - Supported in v9.1+
      Distribution of the Kubernetes cluster to be added.
- clientSecret: System.String
  - Supported in v9.1+
      The client secret for the service account.
- accessToken: System.String
  - Supported in v9.1+
      The access token for the service account.
- region: System.String
  - Supported in v9.1+
      Region of the Kubernetes cluster to be added.
- clientId: System.String
  - Supported in v9.1+
      The client ID for the service account.
- name: System.String
  - Required. Supported in v9.0+
      Name of the Kubernetes cluster to be added.
