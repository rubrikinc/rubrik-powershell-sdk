# New-RscQuerySnappable
## Subcommands
### cdmhierarchysnappablenew
- There is a single argument of type System.String.
- Returns CdmHierarchySnappableNew.
### cdmhierarchysnappablesnew
- There is a single argument of type list of System.Strings.
- Returns list of CdmHierarchySnappableNews.
### contactsearch
SearchSnappableContacts returns a paginated, GraphQL-shaped list of
contact folders and contacts for the given snappable across all
snapshots. Dispatches the raw index hit to the search proxy's
SnappableSearch RPC, then enriches each item with snapshot_time via the
authz GetSnapshot lookup. Encapsulates the response shaping that
previously lived in the GraphQL resolver `snappableContactSearch`.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### emailsearch
SearchSnappableEmails returns a paginated, GraphQL-shaped list of
mailbox folders and emails for the given snappable across all
snapshots. Encapsulates the response shaping (folders + emails
merged as O365ExchangeObject) that previously lived in the
GraphQL resolver `snappableEmailSearch`.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### eventsearch
SearchSnappableEvents returns a paginated, GraphQL-shaped list of
calendar folders and events for the given snappable across all
snapshots. Dispatches the raw index hit to the search proxy's
SnappableSearch RPC, then enriches each item with snapshot_time via the
authz GetSnapshot lookup. Encapsulates the response shaping that
previously lived in the GraphQL resolver `snappableEventSearch`.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### groupbylist
Returns a paginated connection of workload group-by nodes.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - groupBy - SnappableGroupByEnum: Group workloads by field.
    - filter - SnappableGroupByFilterInput: Filter workloads by groups.
    - timezoneOffset - System.Single: Browser timezone offset in hours for time-bucket alignment.
    - requestedAggregations - list of SnappableAggregationsEnums: Aggregation columns to compute.
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
Returns a paginated connection of workloads matching the filter.
Account and subject contexts are derived from req_ctx inside the handler.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - SnappableFilterInput: Filter workloads by input.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - sortOrder - SortOrder: Sort order for workloads.
- Returns SnappableConnection.
### onedrivesearch
Returns OneDrive folders and files for the given workload across all
snapshots, merged as a single O365OnedriveObject interface list
(folders then files).

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter: Optional OneDrive search filter.
- Returns O365OnedriveObjectConnection.
### search
Returns a paginated connection of workloads matching the search filter.
Account and subject contexts are derived from req_ctx inside the handler.
Unlike the plain workload connection, the SLA time range from the filter
is never applied to the base table query.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - SnappableFilterInputWithSearch: Filter workloads by input.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - sortOrder - SortOrder: Sort order for workloads.
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
### tasksearch
SearchSnappableTasks returns a paginated, GraphQL-shaped list of To-Do
lists (task folders) and tasks for the given snappable across all
snapshots. Dispatches the raw index hit to the search proxy's
SnappableSearch RPC, then enriches each item with snapshot_time via the
authz GetSnapshot lookup. Replaces the legacy GraphQL resolver
`snappableTaskSearch`.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - tasksSearchFilter - TasksSearchFilter: Search filter for tasks search.
- Returns O365ExchangeObjectConnection.
### teamsconversationssearch
SearchTeamsConversations returns the per-channel conversation post
counts for the given Teams workload. For each requested channel it
issues a count-only search (no-snapshot or snapshot-scoped) and
aggregates the results into one O365TeamsConversations entry per
channel.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the Teams workload.
    - orgId - System.String: Organization scope for the search.
    - snapshotFidOpt - System.String: Optional snapshot FID. When set, the search
is scoped to this snapshot.
    - teamConvChannels - list of O365TeamConvChannelInputs: The channels to compute conversation counts
for (1..10 entries).
    - teamsConversationsSearchFilter - TeamsConversationsSearchFilter: Optional conversation search
filter (posted time/by, keyword, etc.).
- Returns O365TeamsConversationsConnection.
### teamsdrivesearch
Returns Teams drive folders and files for the given Teams workload across
all snapshots, merged as a single O365OnedriveObject interface list
(folders then files), each stamped with its snapshot's time.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the Teams workload.
    - orgId - System.String: Org UUID.
    - channelId - System.String: Optional Teams channel id; requires channelFolderName.
    - channelFolderName - System.String: Optional Teams channel folder name.
    - teamsDriveSearchFilter - OnedriveSearchFilter: Optional drive search filter.
- Returns O365OnedriveObjectConnection.
