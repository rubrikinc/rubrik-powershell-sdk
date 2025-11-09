### K8sClusterAddInput
Supported in v9.0+
Input to add a Kubernetes cluster.

- id: System.String
  - Supported in v9.1+
UUID of the to be added Kubernetes cluster.
- name: System.String
  - Required. Supported in v9.0+
Name of the Kubernetes cluster to be added.
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
- kuprServerProxyConfig: KuprServerProxyConfigInput
  - Supported in v9.2+
The configuration for the kupr server proxy to be added.
- pullSecret: System.String
  - Supported in v9.1+
The pull secret required for pulling Rubrik container images.
- nadName: System.String
  - Supported in v9.4+
The name of the network attachment definition object.
- transport: System.String
  - Supported in v9.1+
The transport type used for communication with the Kubernetes cluster.
- isAutoPsCreationEnabled: System.Boolean
  - Supported in v9.2+
Specifies whether to enable automatic protection set creation for the Kubernetes cluster.
- clientSecret: System.String
  - Supported in v9.1+
The client secret for the service account.
- nadNamespace: System.String
  - Supported in v9.4+
The namespace to which the network attachment definition object belongs.
- accessToken: System.String
  - Supported in v9.1+
The access token for the service account.
- region: System.String
  - Supported in v9.1+
Region of the Kubernetes cluster to be added.
- onboardingType: System.String
  - Supported in v9.2+
The type of onboarding. It can be kubeconfig or manifest.
- clientId: System.String
  - Supported in v9.1+
The client ID for the service account.
