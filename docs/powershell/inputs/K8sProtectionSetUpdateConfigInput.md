### K8sProtectionSetUpdateConfigInput
Supported in v9.1+
Input to update a Kubernetes protection set.

- customResourceDependencies: list of CustomResourceDependencyInputs
  - Supported in v9.6+
Custom Resource types to capture alongside workloads. Only valid when rsType is "application". Replaces the existing CR dependency list.
- labelSelector: CdmLabelSelectorInput
  - Supported in v9.6+
Label selector for entry-point workload filtering. Only valid when rsType is "application".
- namespaceExcludePatterns: list of System.Strings
  - Supported in v9.6+
Namespace patterns to exclude. Supports "regex:" prefix. Only valid when rsType is "application".
- definition: System.String
  - Supported in v9.1+
Definition of the Kubernetes protection set.
- namespaceIncludePatterns: list of System.Strings
  - Supported in v9.6+
Namespace names to include. Required when rsType is "application". Use ["*"] for wildcard or ["regex:^..."] for patterns.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
