### PureStorageArrayDescendantV1Connection
Paginated list of PureStorageArrayDescendantV1 objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PureStorageArrayDescendantV1Edges
  - List of PureStorageArrayDescendantV1 objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PureStorageArrayDescendantV1s
  - List of PureStorageArrayDescendantV1 objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of PureStorageArrayDescendantV1 objects matching the request arguments.
