### HyperVSCVMMConnection
Paginated list of HyperVSCVMM objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of HyperVSCVMMEdges
  - List of HyperVSCVMM objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of HyperVSCVMMs
  - List of HyperVSCVMM objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of HyperVSCVMM objects matching the request arguments.
