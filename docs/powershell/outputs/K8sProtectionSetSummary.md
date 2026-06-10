### K8sProtectionSetSummary
Supported in v9.1+
Key properties of a Kubernetes protection set.

- id: System.String
  - Required. Supported in v9.1+
ID of the Kubernetes protection set.
- name: System.String
  - Required. Supported in v9.1+
Name of the Kubernetes protection set.
- customResourceDependencies: list of CustomResourceDependencys
  - Custom Resource dependency list. Present for rsType "application" only.
- labelSelector: CdmLabelSelector
  - Label selector for entry-point workload filtering. Present for rsType "application" only.
- rsType: System.String
  - Required. Supported in v9.1+
v9.1-v9.5: Type of the Kubernetes protection set.
v9.6: Type of the Kubernetes protection set. One of: namespace, cluster, application.
- namespaceExcludePatterns: list of System.Strings
  - Namespace exclusion patterns. Present for rsType "application" only.
- definition: System.String
  - Required. Supported in v9.1+
Definition of the Kubernetes protection set.
- namespaceIncludePatterns: list of System.Strings
  - Namespace names or patterns included in an Application Protection Set. Present for rsType "application" only.
- kubernetesNamespace: System.String
  - Supported in v9.1+
v9.1-v9.5: Kubernetes namespace to which the protection set belongs.
v9.6: Kubernetes namespace to which the protection set belongs. Present for rsType "namespace" only.
- kubernetesClusterUuid: System.String
  - Required. Supported in v9.1+
ID of the Kubernetes cluster to which the protection set belongs.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
