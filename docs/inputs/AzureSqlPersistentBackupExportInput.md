### AzureSqlPersistentBackupExportInput
Input for exporting from Rubrik managed persistent backup.

- authMechanism: SqlAuthenticationMechanism
  - Mechanism for SQL Server authentication.
- dbBackupRedundancy: AzureSqlBackupStorageRedundancyType
  - Specifies the redundancy of the backup of the destination database.
- destinationServerCredentials: LoginCredentials
  - Login credentials of the server where the new database needs to be created.
- sessionId: System.String
  - Session ID for the OAuth session. Specify this when using AAD authentication mechanism.
- sourceSnapshotRubrikId: System.String
  - Rubrik ID of the snapshot from which database is being exported.
