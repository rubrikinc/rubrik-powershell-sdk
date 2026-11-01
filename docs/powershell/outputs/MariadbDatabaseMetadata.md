### MariadbDatabaseMetadata
MariaDB database metadata object.

- approxDbSizeInBytes: System.Int64
  - The approximate size of the MariaDB database (in bytes).
- totalTables: System.Int64
  - The total number of tables in the MariaDB database.
- protectableTables: System.Int64
  - The number of protectable tables in the MariaDB database.
- protectionState: MariadbDatabaseProtectionState
  - The protection status of the MariaDB database.
- unprotectedStorageEngines: list of System.Strings
  - List of unsupported storage engines in the MariaDB database.
- storageEngines: list of System.Strings
  - List of all storage engines in the MariaDB database.
