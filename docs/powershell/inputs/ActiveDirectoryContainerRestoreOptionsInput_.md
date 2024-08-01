### ActiveDirectoryContainerRestoreOptionsInput
Supported in v9.0+

- shouldDeleteExtraObjects: System.Boolean
  - Supported in v9.0+
      Whether to delete the objects within a container if Active Directory contains those children objects, but they are missing in the backup copy.
- shouldOnlyRecreateMissingObjects: System.Boolean
  - Supported in v9.0+
      Whether to create the objects within a container only when they are missing in the Active Directory. If set to true, the existing objects will remain untouched.
