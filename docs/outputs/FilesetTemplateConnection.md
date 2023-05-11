### FilesetTemplateConnection
Paginated list of FilesetTemplate objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of FilesetTemplate objects matching the request arguments.
- edges: a list of FilesetTemplateEdges
  - List of FilesetTemplate objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of FilesetTemplates
  - List of FilesetTemplate objects.
- pageInfo: PageInfo
  - General information about this page of results.
