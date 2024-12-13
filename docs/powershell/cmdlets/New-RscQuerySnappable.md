# New-RscQuerySnappable
## Subcommands
### cdmhierarchysnappablenew
- There is a single argument of type System.String.
- Returns CdmHierarchySnappableNew.
### cdmhierarchysnappablesnew
- There is a single argument of type list of System.Strings.
- Returns list of CdmHierarchySnappableNews.
### contactsearch
Search over Exchange contacts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### emailsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### eventsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### groupbylist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - groupBy - SnappableGroupByEnum: Group workloads by field.
    - filter - SnappableGroupByFilterInput: Filter workloads by groups.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - requestedAggregations - list of SnappableAggregationsEnums: List of workload aggregations to retrieve. You can significantly reduce the runtime of the query by specifying a subset of aggregations to retrieve.
- Returns SnappableGroupByConnection.
### hierarchy
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns HierarchySnappableConnection.
### list
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInput: Filter protected objects by input.
- Returns SnappableConnection.
### onedrivesearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### search
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInputWithSearch: Filter workloads by input (with search by name).
- Returns SnappableConnection.
### searchversionedfiles
List of all files in snapshots whose names match the specified search query.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The ID of the workload.
    - searchQuery - System.String: Specifies the name or path prefix used to search for files within a workload.
    - usePrefixSearch - System.Boolean: Determines whether to use a prefix search.
- Returns VersionedFileConnection.
### teamsconversationssearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - snapshotFidOpt - System.String: snapshotFid arg which is of optional type
    - teamConvChannels - list of O365TeamConvChannelInputs: List of channel objects (naturalId and name).
    - teamsConversationsSearchFilter - TeamsConversationsSearchFilter
- Returns O365TeamsConversationsConnection.
### teamsdrivesearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - channelId - System.String
    - channelFolderName - System.String
    - teamsDriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
