### K8sVmMountParametersInput
Supported in v9.4+
Input to mount a Kubernetes virtual machine snapshot to a target cluster and namespace.

- shouldRemoveNetwork: System.Boolean
  - Supported in v9.4+
Specifies whether to remove network configuration on the new virtual machine. Default value is false.
- newVmName: System.String
  - Supported in v9.4+
Name of the new virtual machine created by the mount operation. If not specified, a default name will be generated.
- targetClusterId: System.String
  - Required. Supported in v9.4+
The UUID of the target Kubernetes cluster where the virtual machine should be mounted.
- targetNamespaceId: System.String
  - Required. Supported in v9.4+
The UUID of the target Kubernetes namespace where the virtual machine should be mounted.
- newRunStrategy: System.String
  - Supported in v9.4+
Specifies the run strategy of the mounted virtual machine.
- shouldKeepMacAddresses: System.Boolean
  - Supported in v9.4+
Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. Set to 'true' to keep the MAC addresses of the new virtual machine the same as the original virtual machine. Set to 'false' to assign new MAC addresses. The default is 'false'.
