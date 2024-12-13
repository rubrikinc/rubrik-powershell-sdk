### CrawlConnection
Paginated list of Crawl objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CrawlEdges
  - List of Crawl objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Crawls
  - List of Crawl objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of Crawl objects matching the request arguments.
