### K8sManifestConfigInput
Supported in v9.2+
Input to generate a manifest for the Kubernetes cluster.

- id: System.String
  - Supported in v9.2+
UUID of the Kubernetes cluster to be added.
- name: System.String
  - Required. Supported in v9.2+
Name of the Kubernetes Cluster.
- registry: System.String
  - Supported in v9.2+
Container registry URL for storing Rubrik container images.
- k8sNodeIp: System.String
  - Supported in v9.2+
IP address of the master node of the Kubernetes cluster. This is required only when transport type is NodePort.
- distribution: System.String
  - Required. Supported in v9.2+
Distribution of the Kubernetes cluster to be added.
- pullSecret: System.String
  - Supported in v9.2+
The pull secret required for pulling Rubrik container images.
- nadName: System.String
  - Supported in v9.4+
The name of the network attachment definition object.
- maxPvcsPerAgent: System.Int32
  - Supported in v9.6+
Maximum number of PVCs assigned to a single kupr backup agent. Used as a per-group cap for the node_affinity grouping strategy. Defaults to 30 when omitted. Set to 0 to disable the per-agent cap.
- transport: System.String
  - Required. Supported in v9.2+
The transport type used for communication with the Kubernetes cluster.
- isAutoPsCreationEnabled: System.Boolean
  - Supported in v9.2+
Specifies whether to enable automatic protection set creation for the Kubernetes cluster.
- nadNamespace: System.String
  - Supported in v9.4+
The namespace to which the network attachment definition object belongs.
- maxConcurrentAgents: System.Int32
  - Supported in v9.6+
Maximum number of kupr backup agents allowed to run concurrently against this Kubernetes cluster. Set to 0 (or omit) to leave the throttle unlimited.
- serviceAccount: ServiceAccountInputInput
  - Required. Supported in v9.2+
The RSC service account used for onboarding.
