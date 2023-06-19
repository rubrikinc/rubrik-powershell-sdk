# Invoke-RscQueryOracle
## Subcommands
### Acoexampledownloadlink
Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.

- There is a single argument of type ClusterUuidWithDbIdInput.
- Returns OracleFileDownloadLink.
### Acoparameter
List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.

- There is a single argument of type ClusterUuidWithDbIdInput.
- Returns OracleAcoParameterList.
### Database
Paginated list of Oracle Databases.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns OracleDatabaseConnection.
### Databaselogbackupconfig
Oracle log backup configuration for an Oracle Database.

- There is a single argument of type OracleDbInput.
- Returns OracleLogBackupConfig.
### Dataguardgroup
An Oracle Data Guard Group.

- There is a single argument of type System.String.
- Returns OracleDataGuardGroup.
### Host
An Oracle Host.

- There is a single argument of type System.String.
- Returns OracleHost.
### Hostlogbackupconfig
Oracle Log backup configuration for Oracle Host.

- There is a single argument of type OracleHostInput.
- Returns OracleLogBackupConfig.
### Livemount
Paginated list of Oracle Live Mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of OracleLiveMountFilterInputs: Filter for Oracle live mounts.
    - sortBy - OracleLiveMountSortBy: Sort by argument for Oracle live mounts.
- Returns OracleLiveMountConnection.
### Missedrecoverablerange
Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.

- There is a single argument of type GetOracleDbMissedRecoverableRangesInput.
- Returns OracleMissedRecoverableRangeListResponse.
### Missedsnapshot
Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.

- There is a single argument of type GetMissedOracleDbSnapshotsInput.
- Returns MissedSnapshotListResponse.
### Pdbdetail
Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.

- There is a single argument of type OraclePdbDetailsInput.
- Returns OraclePdbDetails.
### Rac
An Oracle Real Application Cluster.

- There is a single argument of type System.String.
- Returns OracleRac.
### Raclogbackupconfig
Oracle log backup configuration for an Oracle RAC.

- There is a single argument of type OracleRacInput.
- Returns OracleLogBackupConfig.
### Recoverablerange
Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.

- There is a single argument of type GetOracleDbRecoverableRangesInput.
- Returns OracleRecoverableRangeListResponse.
### Topleveldescendant
Paginated list of the highest-level Oracle Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns OracleTopLevelDescendantTypeConnection.
