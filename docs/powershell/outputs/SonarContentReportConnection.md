### SonarContentReportConnection
Paginated list of SonarContentReport objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SonarContentReportEdges
  - List of SonarContentReport objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SonarContentReports
  - List of SonarContentReport objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SonarContentReport objects matching the request arguments.
