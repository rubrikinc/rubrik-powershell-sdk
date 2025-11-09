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
- transport: System.String
  - Required. Supported in v9.2+
The transport type used for communication with the Kubernetes cluster.
- isAutoPsCreationEnabled: System.Boolean
  - Supported in v9.2+
Specifies whether to enable automatic protection set creation for the Kubernetes cluster.
- nadNamespace: System.String
  - Supported in v9.4+
The namespace to which the network attachment definition object belongs.
- serviceAccount: ServiceAccountInputInput
  - Required. Supported in v9.2+
The RSC service account used for onboarding.
