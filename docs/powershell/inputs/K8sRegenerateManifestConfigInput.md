### K8sRegenerateManifestConfigInput
Supported in v9.2+
Input to regenerate a manifest for the Kubernetes cluster.

- maxPvcsPerAgent: System.Int32
  - Supported in v9.6+
Maximum number of PVCs assigned to a single kupr backup agent. Omit to leave the current setting unchanged.
- maxConcurrentAgents: System.Int32
  - Supported in v9.6+
Maximum number of kupr backup agents allowed to run concurrently against this Kubernetes cluster. Omit to leave the current setting unchanged.
- serviceAccount: ServiceAccountInputInput
  - Required. Supported in v9.2+
The RSC service account used for regenerating the manifest.
