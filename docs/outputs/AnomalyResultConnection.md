### AnomalyResultConnection
Paginated list of AnomalyResult objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- aggregation: AnomalyResultAggregation
  - Aggregated anomaly results.
- count: System.Int32
  - Total number of AnomalyResult objects matching the request arguments.
- edges: a list of AnomalyResultEdges
  - List of AnomalyResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of AnomalyResults
  - List of AnomalyResult objects.
- pageInfo: PageInfo
  - General information about this page of results.
