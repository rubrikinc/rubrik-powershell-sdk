### K8sRestoreParametersInput
Supported in v9.0+
v9.0: Input to restore Kubernetes resources from a resource set snapshot.
v9.1+: Input to restore Kubernetes resources from a protection set snapshot.

- filter: System.String
  - Supported in v9.0+
The filter for selecting resources from the snapshot to restore.
- pvcNames: list of System.Strings
  - Supported in v9.1+
- ignoreErrors: System.Boolean
  - Supported in v9.0+
Specifies whether to ignore errors during the restore operation. By default, this value is false.
