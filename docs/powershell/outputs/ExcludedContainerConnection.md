### ExcludedContainerConnection
Paginated list of ExcludedContainer objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ExcludedContainerEdges
  - List of ExcludedContainer objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ExcludedContainers
  - List of ExcludedContainer objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ExcludedContainer objects matching the request arguments.
