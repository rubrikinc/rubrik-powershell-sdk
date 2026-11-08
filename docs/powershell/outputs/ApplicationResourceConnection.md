### ApplicationResourceConnection
Paginated list of ApplicationResource objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ApplicationResourceEdges
  - List of ApplicationResource objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ApplicationResources
  - List of ApplicationResource objects.
- pageInfo: PageInfo
  - General information about this result page.
