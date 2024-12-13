### ActiveDirectorySnappableSearchResponseConnection
Paginated list of ActiveDirectorySnappableSearchResponse objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectorySnappableSearchResponseEdges
  - List of ActiveDirectorySnappableSearchResponse objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectorySnappableSearchResponses
  - List of ActiveDirectorySnappableSearchResponse objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ActiveDirectorySnappableSearchResponse objects matching the request arguments.
