### AddMysqldbInstanceResponse
Supported in v9.3+

- id: System.String
  - Required. Supported in v9.3+
ID of the new MySQL Database instance created.
- asyncRequestStatus: AsyncRequestStatus
  - Required. Supported in v9.3+
Status of the asynchronous job triggered when MySQL database cluster instance is created.
- kosmosTopologyStateId: System.String
  - Topology ID of the MySQL HA cluster backing this instance. Present only when the instance is HA-mode; omitted for standalone instances.
