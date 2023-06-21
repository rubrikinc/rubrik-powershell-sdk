### AzureSqlPersistentBackupExportInput
Input for exporting from Rubrik managed persistent backup.

- sourceSnapshotRubrikId: System.String
  - Rubrik ID of the snapshot from which database is being exported.
- destinationServerCredentials: LoginCredentials
  - Login credentials of the server where the new database needs to be created.
- authMechanism: SqlAuthenticationMechanism
  - Mechanism for SQL Server authentication.
- sessionId: System.String
  - Session ID for the OAuth session. Specify this when using AAD authentication mechanism.
- dbBackupRedundancy: AzureSqlBackupStorageRedundancyType
  - Specifies the redundancy of the backup of the destination database.
