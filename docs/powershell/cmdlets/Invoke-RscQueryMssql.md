# Invoke-RscQueryMssql
## Subcommands
### alldatabaserestorefile
Provides a list of database files to be restored for the specified restore or export operation.

- There is a single argument of type MssqlGetRestoreFilesV1Input.
- Returns V1MssqlGetRestoreFilesV1Response.
### availabilitygroup
A Microsoft SQL Availability Group.

- There is a single argument of type System.String.
- Returns MssqlAvailabilityGroup.
### cdmlogshippingtarget
Paginated list of Microsoft SQL log shipping target.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - MssqlLogShippingTargetSortByInput: Sort by argument for Mssql log shipping targets. Default sort is by id in ascending order.
    - filters - list of MssqlLogShippingTargetFilterInputs: Filters for Mssql log shipping targets. No filters by default.
- Returns MssqlLogShippingTargetConnection.
### compatibleinstance
Returns all compatible instances for export for the specified recovery time.

- There is a single argument of type GetCompatibleMssqlInstancesV1Input.
- Returns MssqlInstanceSummaryListResponse.
### database
Paginated list of Microsoft SQL Databases.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns MssqlDatabaseConnection.
### databaselivemount
Paginated list of Microsoft SQL Database live mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - MssqlDatabaseLiveMountSortByInput: Sort by argument for Mssql database live mounts.
    - filters - list of MssqlDatabaseLiveMountFilterInputs: Filters for Mssql database live mounts.
- Returns MssqlDatabaseLiveMountConnection.
### databasemissedrecoverablerange
List of missed recoverable ranges for a Microsoft SQL Database.

- There is a single argument of type GetMssqlDbMissedRecoverableRangesInput.
- Returns MssqlMissedRecoverableRangeListResponse.
### databasemissedsnapshot
List of missed snapshots for a Microsoft SQL Database.

- There is a single argument of type GetMissedMssqlDbSnapshotsInput.
- Returns MissedSnapshotListResponse.
### databaserestoreestimate
Returns a size estimate for a restore, export, or mount.

- There is a single argument of type MssqlRestoreEstimateV1Input.
- Returns MssqlRestoreEstimateResult.
### defaultpropertie
The current default properties for Microsoft SQL databases.

- There is a single argument of type GetDefaultDbPropertiesV1Input.
- Returns UpdateMssqlDefaultPropertiesReply.
### instance
A Microsoft SQL Instance.

- There is a single argument of type System.String.
- Returns MssqlInstance.
### logshippingtarget
List of filtered Microsoft SQL log shipping targets.

- There is a single argument of type QueryLogShippingConfigurationsV2Input.
- Returns MssqlLogShippingSummaryV2ListResponse.
### recoverablerange
List of recoverable ranges for a Microsoft SQL Database.

- There is a single argument of type GetMssqlDbRecoverableRangesInput.
- Returns MssqlRecoverableRangeListResponse.
### topleveldescendant
Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns MssqlTopLevelDescendantTypeConnection.
