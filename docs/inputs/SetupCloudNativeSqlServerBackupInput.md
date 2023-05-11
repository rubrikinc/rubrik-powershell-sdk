### SetupCloudNativeSqlServerBackupInput
Input required to setup backups.

- adminCredentials: LoginCredentials
  - Credentials for the admin in the databases.
- authMechanism: SqlAuthenticationMechanism
  - Mechanism for SQL Server authentication.
- databaseIds: a list of System.Strings
  - Rubrik IDs of the SQL Server databases.
- sessionId: System.String
  - Session ID for the OAuth session.
