### KubernetesVirtualMachineConnection
Paginated list of KubernetesVirtualMachine objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of KubernetesVirtualMachineEdges
  - List of KubernetesVirtualMachine objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of KubernetesVirtualMachines
  - List of KubernetesVirtualMachine objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of KubernetesVirtualMachine objects matching the request arguments.