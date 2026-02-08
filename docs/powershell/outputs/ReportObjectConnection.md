### ReportObjectConnection
Paginated list of ReportObject objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ReportObjectEdges
  - List of ReportObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ReportObjects
  - List of ReportObject objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ReportObject objects matching the request arguments.
