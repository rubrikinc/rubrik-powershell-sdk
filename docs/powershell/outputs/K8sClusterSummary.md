### K8sClusterSummary
Supported in v9.0+
  Key properties of a Kubernetes cluster.

- id: System.String
  - Required. Supported in v9.0+
  ID of the Kubernetes cluster.
- name: System.String
  - Required. Supported in v9.0+
  Name of the Kubernetes cluster.
- registry: System.String
  - Supported in v9.0+
  Container registry URL for storing Rubrik container images.
- distribution: System.String
  - Supported in v9.1+
  Distribution of the Kubernetes cluster.
- kuprServerProxyConfig: KuprServerProxyConfig
  - The configuration for the kupr server proxy being used.
- transport: System.String
  - Supported in v9.1+
  The transport type used for communication with the Kubernetes cluster.
- lastRefreshTime: DateTime
  - Supported in v9.0+
  Last refresh time of the Kubernetes cluster.
- region: System.String
  - Supported in v9.1+
  Region of the Kubernetes cluster.
- onboardingType: System.String
  - The type of onboarding. It can be kubeconfig or manifest.
- status: System.String
  - Required. Supported in v9.0+
  Connection status of the Kubernetes cluster.
