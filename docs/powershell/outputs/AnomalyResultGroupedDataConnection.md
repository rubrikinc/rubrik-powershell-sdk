### AnomalyResultGroupedDataConnection
Paginated list of AnomalyResultGroupedData objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AnomalyResultGroupedDataEdges
  - List of AnomalyResultGroupedData objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AnomalyResultGroupedDatas
  - List of AnomalyResultGroupedData objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AnomalyResultGroupedData objects matching the request arguments.
