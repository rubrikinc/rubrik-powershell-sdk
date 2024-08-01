### AddCloudNativeSqlServerBackupCredentialsInput
Input required to add credentials for performing backups.

- objectIds: list of System.Strings
  - Rubrik IDs of the objects. Some examples of objects are: Azure Subscriptions, Resource Groups.
- workloadType: WorkloadLevelHierarchy
  - The object type to which the credentials apply to.
- backupCredentials: LoginCredentials
  - Credentials for the user in the databases with authorization to perform backups.
- logicAppName: System.String
  - Name of the Azure Logic Application you want to use to clean up the PiTR exported database.
- logicAppApiKey: System.String
  - API key for the Azure Logic Application.
