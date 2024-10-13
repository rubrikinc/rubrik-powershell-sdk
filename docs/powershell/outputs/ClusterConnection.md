### ClusterConnection
Paginated list of Cluster objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ClusterEdges
  - List of Cluster objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Clusters
  - List of Cluster objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Cluster objects matching the request arguments.
- aggregateClusterStatistics: ClusterStatsAggregation
  - Aggregate statistics across Clusters with respect for the applied filters and pagination arguments.
- aggregateClusterHealth: ClusterHealthAggregation
  - Aggregate Rubrik clusters' health information based on filters and pagination arguments.
