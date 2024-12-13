### AnomalyResultConnection
Paginated list of AnomalyResult objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AnomalyResultEdges
  - List of AnomalyResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AnomalyResults
  - List of AnomalyResult objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AnomalyResult objects matching the request arguments.
- aggregation: AnomalyResultAggregation
  - Aggregated anomaly results.
