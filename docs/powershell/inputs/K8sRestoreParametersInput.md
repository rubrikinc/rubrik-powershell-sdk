### K8sRestoreParametersInput
Supported in v9.0+
v9.0: Input to restore Kubernetes resources from a resource set snapshot.
v9.1+: Input to restore Kubernetes resources from a protection set snapshot.

- namespacesToRestore: list of System.Strings
  - Optional list of namespaces to selectively restore from an Application Protection Set snapshot. When specified, only resources in these namespaces are restored. When omitted, all namespaces are restored.
- filter: System.String
  - Supported in v9.0+
The filter for selecting resources from the snapshot to restore.
- storageMapping: StorageMappingInput
  - Supported in v9.5+
The storage mapping to be used for the restore operation.
- pvcNames: list of System.Strings
  - Supported in v9.1+
- ignoreErrors: System.Boolean
  - Supported in v9.0+
Specifies whether to ignore errors during the restore operation. By default, this value is false.
