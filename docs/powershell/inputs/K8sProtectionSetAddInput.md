### K8sProtectionSetAddInput
Supported in v9.1+
Input to add a Kubernetes protection set.

- creationType: System.String
  - Supported in v9.2+
The type of method used to create a protection set. Possible values are: automatic, RSC, or CRD.
- name: System.String
  - Required. Supported in v9.1+
Name of the Kubernetes protection set to be added.
- customResourceDependencies: list of CustomResourceDependencyInputs
  - Custom Resource types to capture alongside workloads. Only valid when rsType is "application".
- labelSelector: CdmLabelSelectorInput
  - Label selector for entry-point workload filtering. Only valid when rsType is "application".
- rsType: System.String
  - Required. Supported in v9.1+
v9.1-v9.5: Type of the Kubernetes protection set to be added.
v9.6: Type of the Kubernetes protection set to be added. One of: namespace, cluster, application.
- namespaceExcludePatterns: list of System.Strings
  - Namespace patterns to exclude. Supports "regex:" prefix. Only valid when rsType is "application".
- definition: System.String
  - Required. Supported in v9.1+
Definition of the Kubernetes protection set to be added.
- namespaceIncludePatterns: list of System.Strings
  - Namespace names to include. Required when rsType is "application". Use ["*"] for wildcard or ["regex:^..."] for patterns.
- kubernetesNamespace: System.String
  - Supported in v9.1+
v9.1-v9.5: Kubernetes namespace to which the protection set to be added belongs.
v9.6: Kubernetes namespace to which the protection set to be added belongs. Required when rsType is "namespace".
- kubernetesClusterId: System.String
  - Required. Supported in v9.1+
ID of the Kubernetes cluster to which the protection set to be added belongs.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
