### CrawlObjConnection
Paginated list of CrawlObj objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of CrawlObj objects matching the request arguments.
- edges: a list of CrawlObjEdges
  - List of CrawlObj objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of CrawlObjs
  - List of CrawlObj objects.
- pageInfo: PageInfo
  - General information about this page of results.
