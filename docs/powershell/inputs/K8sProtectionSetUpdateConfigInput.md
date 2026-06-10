### K8sProtectionSetUpdateConfigInput
Supported in v9.1+
Input to update a Kubernetes protection set.

- customResourceDependencies: list of CustomResourceDependencyInputs
  - Custom Resource types to capture alongside workloads. Replace the existing CR dependency list.
- definition: System.String
  - Supported in v9.1+
Definition of the Kubernetes protection set.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
