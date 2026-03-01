### CreateAutomatedRestoreMysqldbInstanceReply
Response for the automated restore request of a MySQL database instance.

- id: System.String
  - Required. Supported in v9.5+
ID of the MySQL recovery stack used to track the recovery progress.
- asyncRequestStatus: AsyncRequestStatus
  - Required. Supported in v9.5+
Status of the asynchronous job triggered when you initiate the recovery operation for the MySQL instance.
