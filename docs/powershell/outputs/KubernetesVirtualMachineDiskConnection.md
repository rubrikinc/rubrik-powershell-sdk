### KubernetesVirtualMachineDiskConnection
Paginated list of KubernetesVirtualMachineDisk objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of KubernetesVirtualMachineDiskEdges
  - List of KubernetesVirtualMachineDisk objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of KubernetesVirtualMachineDisks
  - List of KubernetesVirtualMachineDisk objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of KubernetesVirtualMachineDisk objects matching the request arguments.