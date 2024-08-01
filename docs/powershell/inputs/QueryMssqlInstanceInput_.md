### QueryMssqlInstanceInput
Input for querying Microsoft SQL Server instances.

- rootId: System.String
  - Include only instances that belong to this root.
- primaryClusterId: System.String
  - Limits the instances returned within one cluster specified by primary_cluster_id.
- snappableStatus: QueryMssqlInstanceRequestWorkloadStatus
  - Determines whether Microsoft SQL Server instances are retrieved with additional privilege checks.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
