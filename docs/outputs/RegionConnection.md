### RegionConnection
Paginated list of Region objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of Region objects matching the request arguments.
- edges: a list of RegionEdges
  - List of Region objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of Regions
  - List of Region objects.
- pageInfo: PageInfo
  - General information about this page of results.
