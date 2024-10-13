### HyperVVirtualMachineConnection
Paginated list of HyperVVirtualMachine objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of HyperVVirtualMachineEdges
  - List of HyperVVirtualMachine objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of HyperVVirtualMachines
  - List of HyperVVirtualMachine objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of HyperVVirtualMachine objects matching the request arguments.
