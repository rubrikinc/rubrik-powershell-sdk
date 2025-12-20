### K8sVMExportParametersInput
Supported in v9.3+
Input to export Kubernetes resources from a virtual machine snapshot.

- targetNamespaceName: System.String
  - Required. Supported in v9.3+
The virtual machine will be exported to this namespace. If the namespace does not exist, it will be created.
- filter: System.String
  - Supported in v9.3+
The filter for selecting resources from the snapshot to export.
- runStrategy: System.String
  - Supported in v9.3+
Specifies the run strategy of the exported virtual machine.
- storageMapping: StorageMappingInput
  - The storage mapping to be used for the export operation.
- pvcNames: list of System.Strings
  - Supported in v9.3+
- targetClusterId: System.String
  - Required. Supported in v9.3+
The UUID of the target Kubernetes cluster to which the resources should be exported.
- ignoreErrors: System.Boolean
  - Supported in v9.3+
Specifies whether to ignore errors during the export operation.
- shouldKeepMacAddresses: System.Boolean
  - Supported in v9.3+
Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. Set to 'true' to keep the MAC addresses of the new virtual machine the same as the original virtual machine. Set to 'false' to assign new MAC addresses.
