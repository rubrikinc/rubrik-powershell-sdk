### WorkloadAnomalyConnection
Paginated list of WorkloadAnomaly objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- aggregation: AggregatedValues
  - Aggregation values calculated across all results.
- count: System.Int32
  - Total number of WorkloadAnomaly objects matching the request arguments.
- edges: a list of WorkloadAnomalyEdges
  - List of WorkloadAnomaly objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of WorkloadAnomalys
  - List of WorkloadAnomaly objects.
- pageInfo: PageInfo
  - General information about this page of results.
