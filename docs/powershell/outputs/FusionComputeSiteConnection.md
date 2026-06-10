### FusionComputeSiteConnection
Paginated list of FusionComputeSite objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FusionComputeSiteEdges
  - List of FusionComputeSite objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FusionComputeSites
  - List of FusionComputeSite objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FusionComputeSite objects matching the request arguments.
