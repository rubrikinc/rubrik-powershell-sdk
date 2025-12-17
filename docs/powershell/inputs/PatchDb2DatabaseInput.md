### PatchDb2DatabaseInput
Input for patching Db2 database.

- id: System.String
  - Required. ID of the Db2 database.
- userNote: System.String
  - Required. User note to associate with audits.
- db2DatabaseConfig: Db2DatabaseConfigInput
  - Required. The request object includes parameters such as backupSessions and backupParallelism to update the Db2 database properties on the Rubrik cluster.
