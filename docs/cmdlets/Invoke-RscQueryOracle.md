# Invoke-RscQueryOracle
## Subcommands
### AcoExampleDownloadLink
Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.

- The Input parameter takes a single value of type ClusterUuidWithDbIdInput.
- Returns OracleFileDownloadLink.
### AcoParameter
List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.

- The Input parameter takes a single value of type ClusterUuidWithDbIdInput.
- Returns OracleAcoParameterList.
### DataGuardGroup
An Oracle Data Guard Group.

- The Input parameter takes a single value of type System.String.
- Returns OracleDataGuardGroup.
### Database
An Oracle Database.

- The Input parameter takes a single value of type System.String.
- Returns OracleDatabase.
### DatabaseLogBackupConfig
Oracle log backup configuration for an Oracle Database.

- The Input parameter takes a single value of type OracleDbInput.
- Returns OracleLogBackupConfig.
### Host
An Oracle Host.

- The Input parameter takes a single value of type System.String.
- Returns OracleHost.
### HostLogBackupConfig
Oracle Log backup configuration for Oracle Host.

- The Input parameter takes a single value of type OracleHostInput.
- Returns OracleLogBackupConfig.
### LiveMount
Paginated list of Oracle Live Mounts.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - a list of OracleLiveMountFilterInputs: Filter for Oracle live mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - OracleLiveMountSortBy: Sort by argument for Oracle live mounts.
- Returns OracleLiveMountConnection.
### MissedRecoverableRange
Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.

- The Input parameter takes a single value of type GetOracleDbMissedRecoverableRangesInput.
- Returns OracleMissedRecoverableRangeListResponse.
### MissedSnapshot
Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.

- The Input parameter takes a single value of type GetMissedOracleDbSnapshotsInput.
- Returns MissedSnapshotListResponse.
### PdbDetail
Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.

- The Input parameter takes a single value of type OraclePdbDetailsInput.
- Returns OraclePdbDetails.
### Rac
An Oracle Real Application Cluster.

- The Input parameter takes a single value of type System.String.
- Returns OracleRac.
### RacLogBackupConfig
Oracle log backup configuration for an Oracle RAC.

- The Input parameter takes a single value of type OracleRacInput.
- Returns OracleLogBackupConfig.
### RecoverableRange
Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.

- The Input parameter takes a single value of type GetOracleDbRecoverableRangesInput.
- Returns OracleRecoverableRangeListResponse.
### TopLevelDescendant
Paginated list of the highest-level Oracle Objects accessible by the current user.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns OracleTopLevelDescendantTypeConnection.
