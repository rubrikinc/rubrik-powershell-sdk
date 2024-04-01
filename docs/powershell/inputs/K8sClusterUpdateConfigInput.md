### K8sClusterUpdateConfigInput
Supported in v9.1+
  Input to update a Kubernetes cluster.

- kubeconfig: System.String
  - Supported in v9.1+
      Kubeconfig is a YAML string to store Kubernetes cluster authentication information. You can get this config file directly from the cluster administrator or from a cloud platform if you are using managed Kubernetes cluster.
- registry: System.String
  - Supported in v9.1+
      Container registry URL for storing Rubrik container images.
- serviceAccountName: System.String
  - Supported in v9.1+
      The name of the RSC service account.
- clientSecret: System.String
  - Supported in v9.1+
      The client secret for the service account.
- accessToken: System.String
  - Supported in v9.1+
      The access token for the service account.
- cloudAccountId: System.String
  - Supported in v9.1+
      The cloud account for the Rubrik cluster to establish a connection with the EKS Kubernetes cluster.
- clientId: System.String
  - Supported in v9.1+
      The client ID for the service account.
