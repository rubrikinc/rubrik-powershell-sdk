# Invoke-RscQueryMssql
## Subcommands
### AvailabilityGroup
A Microsoft SQL Availability Group.

- The Input parameter takes a single value of type System.String.
- Returns MssqlAvailabilityGroup.
### CompatibleInstance
Returns all compatible instances for export for the specified recovery time.

- The Input parameter takes a single value of type GetCompatibleMssqlInstancesV1Input.
- Returns MssqlInstanceSummaryListResponse.
### Database
A Microsoft SQL Database.

- The Input parameter takes a single value of type System.String.
- Returns MssqlDatabase.
### DatabaseLiveMount
Paginated list of Microsoft SQL Database live mounts.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - a list of MssqlDatabaseLiveMountFilterInputs: Filters for Mssql database live mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - MssqlDatabaseLiveMountSortByInput: Sort by argument for Mssql database live mounts.
- Returns MssqlDatabaseLiveMountConnection.
### DatabaseMissedRecoverableRange
List of missed recoverable ranges for a Microsoft SQL Database.

- The Input parameter takes a single value of type GetMssqlDbMissedRecoverableRangesInput.
- Returns MssqlMissedRecoverableRangeListResponse.
### DatabaseMissedSnapshot
List of missed snapshots for a Microsoft SQL Database.

- The Input parameter takes a single value of type GetMissedMssqlDbSnapshotsInput.
- Returns MissedSnapshotListResponse.
### DatabaseRestoreEstimate
Returns a size estimate for a restore, export, or mount.

- The Input parameter takes a single value of type MssqlRestoreEstimateV1Input.
- Returns MssqlRestoreEstimateResult.
### DefaultPropertie
The current default properties for Microsoft SQL databases.

- The Input parameter takes a single value of type GetDefaultDbPropertiesV1Input.
- Returns UpdateMssqlDefaultPropertiesReply.
### Instance
A Microsoft SQL Instance.

- The Input parameter takes a single value of type System.String.
- Returns MssqlInstance.
### LogShippingTarget
List of filtered Microsoft SQL log shipping targets.

- The Input parameter takes a single value of type QueryLogShippingConfigurationsV2Input.
- Returns MssqlLogShippingSummaryV2ListResponse.
### RecoverableRange
List of recoverable ranges for a Microsoft SQL Database.

- The Input parameter takes a single value of type GetMssqlDbRecoverableRangesInput.
- Returns MssqlRecoverableRangeListResponse.
### TopLevelDescendant
Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns MssqlTopLevelDescendantTypeConnection.
### allDatabaseRestoreFile
Provides a list of database files to be restored for the specified restore or export operation.

- The Input parameter takes a single value of type MssqlGetRestoreFilesV1Input.
- Returns V1MssqlGetRestoreFilesV1Response.
### cdmLogShippingTarget
A single Microsoft SQL log shipping target.

- The Input parameter takes a single value of type System.String.
- Returns MssqlLogShippingTarget.
