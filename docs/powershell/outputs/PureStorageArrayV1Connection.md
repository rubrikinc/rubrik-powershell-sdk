### PureStorageArrayV1Connection
Paginated list of PureStorageArrayV1 objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PureStorageArrayV1Edges
  - List of PureStorageArrayV1 objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PureStorageArrayV1s
  - List of PureStorageArrayV1 objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of PureStorageArrayV1 objects matching the request arguments.
