### StartMssqlLogShippingApplyLogsJobInput
Input for starting an asynchronous job to apply pending transaction logs to a SQL Server log shipping secondary database.

- id: System.String
  - Required. ID of the log shipping configuration object for the specified secondary database.
- config: MssqlLogShippingApplyLogsInput
  - Required. Configuration parameters for the apply logs operation.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
