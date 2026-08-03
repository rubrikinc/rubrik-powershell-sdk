### K8sClusterSummary
Supported in v9.0+
Key properties of a Kubernetes cluster.

- id: System.String
  - Required. Supported in v9.0+
ID of the Kubernetes cluster.
- name: System.String
  - Required. Supported in v9.0+
Name of the Kubernetes cluster.
- crdServiceAccountInfo: ServiceAccountInfo
  - Supported in v9.2+
The details of the RSC service account used for CRD operations.
- registry: System.String
  - Supported in v9.0+
Container registry URL for storing Rubrik container images.
- distribution: System.String
  - Supported in v9.1+
Distribution of the Kubernetes cluster.
- kuprServerProxyConfig: KuprServerProxyConfig
  - Supported in v9.2+
The configuration for the kupr server proxy being used.
- maxPvcsPerAgent: System.Int32
  - Maximum number of PVCs assigned to a single kupr backup agent. Omitted when FF is off.
- transport: System.String
  - Supported in v9.1+
The transport type used for communication with the Kubernetes cluster.
- maxConcurrentAgents: System.Int32
  - Maximum number of kupr backup agents allowed to run concurrently. Omitted when FF is off.
- onboardingServiceAccountInfo: ServiceAccountInfo
  - Supported in v9.2+
The details of the RSC service account used for onboarding using manifest.
- lastRefreshTime: DateTime
  - Supported in v9.0+
Last refresh time of the Kubernetes cluster.
- region: System.String
  - Supported in v9.1+
Region of the Kubernetes cluster.
- onboardingType: System.String
  - Supported in v9.2+
The type of onboarding. It can be kubeconfig or manifest.
- pvcGroupingStrategy: System.String
  - PVC grouping strategy (node_affinity | count | none). Omitted when FF is off.
- status: System.String
  - Required. Supported in v9.0+
Connection status of the Kubernetes cluster.
