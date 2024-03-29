### K8sProtectionSetSummary
Supported in v9.1+
  Key properties of a Kubernetes protection set.

- id: System.String
  - Required. Supported in v9.1+
  ID of the Kubernetes protection set.
- name: System.String
  - Required. Supported in v9.1+
  Name of the Kubernetes protection set.
- rsType: System.String
  - Required. Supported in v9.1+
  Type of the Kubernetes protection set.
- definition: System.String
  - Required. Supported in v9.1+
  Definition of the Kubernetes protection set.
- kubernetesNamespace: System.String
  - Supported in v9.1+
  Kubernetes namespace to which the protection set belongs.
- kubernetesClusterUuid: System.String
  - Required. Supported in v9.1+
  ID of the Kubernetes cluster to which the protection set belongs.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
