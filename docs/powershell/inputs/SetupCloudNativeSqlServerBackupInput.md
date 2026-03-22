### SetupCloudNativeSqlServerBackupInput
Input required to setup backups.

- databaseIds: list of System.Strings
  - Rubrik IDs of the SQL Server databases.
- adminCredentials: LoginCredentials
  - Credentials for the admin in the databases.
- authMechanism: SqlAuthenticationMechanism
  - Mechanism for SQL Server authentication.
- sessionId: System.String
  - Session ID for the OAuth session.
- serverIds: list of System.Strings
  - Rubrik IDs of the SQL Server. Currently only supported for Azure SQL Managed Instance BAK backups.
