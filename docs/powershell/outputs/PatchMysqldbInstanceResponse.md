### PatchMysqldbInstanceResponse
Supported in v9.3+

- asyncRequestStatus: AsyncRequestStatus
  - Required. Supported in v9.3+
Status of the asynchronous job triggered when MySQL instance is updated.
- kosmosTopologyStateId: System.String
  - Topology ID of the MySQL HA cluster backing this instance. Present only when the instance is HA-mode; omitted for standalone instances.
