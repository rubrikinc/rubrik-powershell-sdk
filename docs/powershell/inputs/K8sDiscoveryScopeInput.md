### K8sDiscoveryScopeInput
Limits discovery and protection to a subset of namespaces and/or label selectors. When omitted, all namespaces in the cluster are discovered.

- labelSelectors: list of K8sLabelSelectorInputs
  - Label selectors used to filter namespaces or workloads.
- namespaces: list of System.Strings
  - List of Kubernetes namespace names to discover and protect.
