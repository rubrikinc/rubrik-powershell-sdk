### AddCloudNativeSqlServerBackupCredentialsInput
Input required to add credentials for performing backups.

- objectIds: list of System.Strings
  - Rubrik IDs of the objects. Some examples of objects are: Azure Subscriptions, Resource Groups.
- workloadType: WorkloadLevelHierarchy
  - The object type to which the credentials apply to.
- backupCredentials: LoginCredentials
  - Credentials for the user in the databases with authorization to perform backups.
