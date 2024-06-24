# New-RscQueryMssql
## Subcommands
### availabilitygroup
A Microsoft SQL Availability Group.

- There is a single argument of type System.String.
- Returns MssqlAvailabilityGroup.
### cdmlogshippingtarget
A single Microsoft SQL log shipping target.

- There is a single argument of type System.String.
- Returns MssqlLogShippingTarget.
### cdmlogshippingtargets
Paginated list of Microsoft SQL log shipping target.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - MssqlLogShippingTargetSortByInput: Sort by argument for Mssql log shipping targets. Default sort is by id in ascending order.
    - filters - list of MssqlLogShippingTargetFilterInputs: Filters for Mssql log shipping targets. No filters by default.
- Returns MssqlLogShippingTargetConnection.
### compatibleinstances
Returns all compatible instances for export for the specified recovery time.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - input - GetCompatibleMssqlInstancesV1Input: Input for V1GetCompatibleMssqlInstancesV1.
    - sortBy - MssqlCompatibleInstancesSortByInput: Sort by argument for MSSQL compatible instances.
    - filters - list of MssqlCompatibleInstancesFilterInputs: Filters for MSSQL compatible instances.
- Returns MssqlInstanceSummaryListResponse.
### database
A Microsoft SQL Database.

- There is a single argument of type System.String.
- Returns MssqlDatabase.
### databaselivemounts
Paginated list of Microsoft SQL Database live mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - MssqlDatabaseLiveMountSortByInput: Sort by argument for Mssql database live mounts.
    - filters - list of MssqlDatabaseLiveMountFilterInputs: Filters for Mssql database live mounts.
- Returns MssqlDatabaseLiveMountConnection.
### databasemissedrecoverableranges
List of missed recoverable ranges for a Microsoft SQL Database.

- There is a single argument of type GetMssqlDbMissedRecoverableRangesInput.
- Returns MssqlMissedRecoverableRangeListResponse.
### databasemissedsnapshots
List of missed snapshots for a Microsoft SQL Database.

- There is a single argument of type GetMissedMssqlDbSnapshotsInput.
- Returns MissedSnapshotListResponse.
### databaserestoreestimate
Returns a size estimate for a restore, export, or mount.

- There is a single argument of type MssqlRestoreEstimateV1Input.
- Returns MssqlRestoreEstimateResult.
### databaserestorefiles
Provides a list of database files to be restored for the specified restore or export operation.

- There is a single argument of type MssqlGetRestoreFilesV1Input.
- Returns V1MssqlGetRestoreFilesV1Response.
### databases
Paginated list of Microsoft SQL Databases.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns MssqlDatabaseConnection.
### defaultproperties
The current default properties for Microsoft SQL databases.

- There is a single argument of type GetDefaultDbPropertiesV1Input.
- Returns UpdateMssqlDefaultPropertiesReply.
### defaultpropertiesoncluster
The current default properties for Microsoft SQL databases.

- There is a single argument of type ClusterUuidWithMssqlObjectIdInput.
- Returns MssqlDefaultPropertiesOnClusterReply.
### instance
A Microsoft SQL Instance.

- There is a single argument of type System.String.
- Returns MssqlInstance.
### logshippingtargets
List of filtered Microsoft SQL log shipping targets.

- There is a single argument of type QueryLogShippingConfigurationsV2Input.
- Returns MssqlLogShippingSummaryV2ListResponse.
### recoverableranges
List of recoverable ranges for a Microsoft SQL Database.

- There is a single argument of type GetMssqlDbRecoverableRangesInput.
- Returns MssqlRecoverableRangeListResponse.
### topleveldescendants
Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns MssqlTopLevelDescendantTypeConnection.
