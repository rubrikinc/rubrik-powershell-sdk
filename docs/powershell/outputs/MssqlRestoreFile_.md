### MssqlRestoreFile
Supported in v5.0+

- fileId: System.Int64
  - Required. Supported in v5.0+
  Original file ID of the database file to be restored.
- logicalName: System.String
  - Required. Supported in v5.0+
  Logical name of the database file to be restored.
- originalName: System.String
  - Required. Supported in v5.0+
  Original filename of the database file to be restored.
- originalPath: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2: Original path of the database file to be restored.
  v5.3+: Original path to the database file to be restored.
- fileType: MssqlDatabaseFileType
  - 
