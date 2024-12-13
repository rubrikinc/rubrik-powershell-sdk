# New-RscQueryMssql
## Subcommands
### availabilitygroup
A Microsoft SQL Availability Group.

- There is a single argument of type System.String.
- Returns MssqlAvailabilityGroup.
### availabilitygroupdatabasevirtualgroups
Paginated list of virtual groups for MSSQL databases.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
    - filters - list of MssqlAvailabilityGroupDatabaseVirtualGroupFilterInputs: Filters for MSSQL availability group database virtual groups. The default is no filters, and all objects are returned.
    - sortBy - MssqlAvailabilityGroupDatabaseVirtualGroupSortByInput: Sort by argument is for MSSQL availability group database virtual groups. By default, sort according to ID in ascending order.
    - sortOrder - MssqlAvailabilityGroupDatabaseVirtualGroupSortOrderInput: Sort order argument for MSSQL availability group database virtual groups.
- Returns MssqlDatabaseVirtualGroupConnection.
### availabilitygroupvirtualgroups
Paginated list of virtual groups for MSSQL availability groups.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - filters - list of MssqlAvailabilityGroupVirtualGroupFilterInputs: Filters for MSSQL availability group virtual groups. Default to no filters and all objects are returned.
    - sortBy - MssqlAvailabilityGroupVirtualGroupSortByInput: Sort by argument for MSSQL availability group virtual groups. Default sort is by ID in ascending order.
    - sortOrder - MssqlAvailabilityGroupVirtualGroupSortOrderInput: Sort order argument for MSSQL availability group virtual groups.
- Returns MssqlAvailabilityGroupVirtualGroupConnection.
### cdmlogshippingtarget
A single Microsoft SQL log shipping target.

- There is a single argument of type System.String.
- Returns MssqlLogShippingTarget.
### cdmlogshippingtargets
Paginated list of Microsoft SQL log shipping target.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - MssqlLogShippingTargetSortByInput: Sort by argument for MSSQL log shipping targets. Default sort is by ID in ascending order.
    - filters - list of MssqlLogShippingTargetFilterInputs: Filters for Mssql log shipping targets. No filters by default.
- Returns MssqlLogShippingTargetConnection.
### compatibleinstances
Returns all compatible instances for export for the specified recovery time.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
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
### jobstatus
Get details for an async request

Supported in v5.0+
Returns the task object for an async request related to SQL Server databases.

- There is a single argument of type GetMssqlAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns MssqlTopLevelDescendantTypeConnection.
