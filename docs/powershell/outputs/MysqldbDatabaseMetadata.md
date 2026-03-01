### MysqldbDatabaseMetadata
MySQL database metadata object.

- approxDbSizeInBytes: System.Int64
  - The approximate size of the MySQL database (in bytes).
- totalTables: System.Int64
  - The total number of tables in the MySQL database.
- protectableTables: System.Int64
  - The number of protectable tables in the MySQL database.
- protectionState: MysqldbDatabaseProtectionStateEnum
  - The protection status of the MySQL database.
- unprotectedStorageEngines: list of System.Strings
  - List of unsupported storage engines in the MySQL database.
