# Invoke-RscQuerySnappable
## Subcommands
### Allresourcespec
Describes the snappable resource specs.

- There is a single argument of type list of SnappableIdentifierInputs.
- Returns list of ResourceSpecs.
### Cdmhierarchynew
- There is a single argument of type System.String.
- Returns CdmHierarchySnappableNew.
### Cdmhierarchysnew
- There is a single argument of type list of System.Strings.
- Returns list of CdmHierarchySnappableNews.
### Contactsearch
Search over Exchange contacts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### Emailsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### Eventsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### Groupbyatspecifiedtimeconnection
- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - SnappableGroupByEnum: Group workloads by field.
    - filter - SnappableGroupByFilterInput: Filter workloads by groups.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - specifiedTime - DateTime: Time to calculate the group by.
    - requestedAggregations - list of SnappableAggregationsEnums: List of workload aggregations to retrieve. You can significantly reduce the runtime of the query by specifying a subset of aggregations to retrieve.
- Returns SnappableGroupByAtSpecifiedTimeConnection.
### Groupbyconnection
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - SnappableGroupByEnum: Group workloads by field.
    - filter - SnappableGroupByFilterInput: Filter workloads by groups.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - requestedAggregations - list of SnappableAggregationsEnums: List of workload aggregations to retrieve. You can significantly reduce the runtime of the query by specifying a subset of aggregations to retrieve.
- Returns SnappableGroupByConnection.
### Hierarchy
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns HierarchySnappableConnection.
### Legalholdsnapshotsfor
List of legal hold snapshots for a workload.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - LegalHoldSnapshotsForSnappableInput: Query legal hold snapshots for a workload.
- Returns LegalHoldSnapshotDetailConnection.
### List
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInput: Filter protected objects by input.
- Returns SnappableConnection.
### Onedrivesearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### Searchconnection
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInputWithSearch: Filter workloads by input (with search by name).
- Returns SnappableConnection.
### Searchversionedfile
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String
    - searchQuery - System.String
- Returns VersionedFileConnection.
### Sharepointdrivesearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
    - siteChildType - SharePointDescendantType: The site child type for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### Sharepointlistsearch
Search list objects.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### Snapshotofaconnection
Returns a list of snapshots for a workload.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The FID of the workload.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filter for snapshot connection.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnapshotQuerySortByField: Sort snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
- Returns GenericSnapshotConnection.
### Snapshotofsconnection
Returns list of snapshots for a list of workloads.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - snappableIds - list of System.Strings: Workload UUIDs.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filter for snapshot connection.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnapshotQuerySortByField: Sort snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
- Returns GenericSnapshotConnection.
### Swithlegalholdsnapshotssummary
List of workloads with legal hold snapshots.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - SnappablesWithLegalHoldSnapshotsInput: Input to retrieve workloads with legal hold snapshots.
- Returns LegalHoldSnappableDetailConnection.
### Teamsconversationssearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - snapshotFidOpt - System.String: snapshotFid arg which is of optional type
    - teamConvChannels - list of O365TeamConvChannelInputs: List of channel objects (naturalId and name).
    - teamsConversationsSearchFilter - TeamsConversationsSearchFilter
- Returns O365TeamsConversationsConnection.
### Teamsdrivesearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - channelId - System.String
    - channelFolderName - System.String
    - teamsDriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
