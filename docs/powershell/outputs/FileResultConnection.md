### FileResultConnection
Paginated list of FileResult objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FileResultEdges
  - List of FileResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FileResults
  - List of FileResult objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of FileResult objects matching the request arguments.
- hasLatestData: System.Boolean
  - Specifies whether the response contains the latest indexed data or not.
- indexingVersion: System.Int32
  - Specifies the indexing version. 
