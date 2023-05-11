### BulkUpdateMssqlDbsInput
Input for BulkUpdateMssqlDbs.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- dbsUpdateProperties: a list of MssqlDbUpdateIdInputs
  - Required. Properties to update for each database.
