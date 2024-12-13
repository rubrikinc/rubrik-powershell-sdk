### K8sExportParametersInput
Supported in v9.0+
  v9.0: Input to export Kubernetes resources from a resource set snapshot.
  v9.1+: Input to export Kubernetes resources from a protection set snapshot.

- filter: System.String
  - Supported in v9.0+
      The filter for selecting resources from the snapshot to export.
- pvcNames: list of System.Strings
  - Supported in v9.1+
- virtualMachineRunStrategy: System.String
  - Specifies the run strategy of the exported virtual machine.
- shouldDeleteNamespaceIfExportFailed: System.Boolean
  - Supported in v9.1+
      Specifies whether to delete exported namespace if the export failed. By default, this value is false.
- ignoreErrors: System.Boolean
  - Supported in v9.0+
      Specifies whether to ignore errors during the export operation. By default, this value is false.
- shouldKeepVirtualMachineMacAddresses: System.Boolean
  - Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. Set to 'true' to keep the MAC addresses of the new virtual machine the same as the original virtual machine. Set to 'false' to assign new MAC addresses.
- targetClusterId: System.String
  - Required. Supported in v9.0+
      The UUID of the target Kubernetes cluster to which the resources should be exported.
- targetNamespaceName: System.String
  - Required. Supported in v9.0+
      The name of the new Kubernetes namespace that will be created. The resources will be exported to the new namespace.
