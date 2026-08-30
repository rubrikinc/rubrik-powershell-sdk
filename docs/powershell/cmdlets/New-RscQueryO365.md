# New-RscQueryO365
## Subcommands
### adgroups
All AD Groups belonging to the O365 organization.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - adGroupSearchFilter - System.String: AD group search filter.
- Returns list of AdGroups.
### browseteamconvchannels
Browse channels in a Teams conversations snapshot.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFidOpt - System.String: snapshotFid arg which is of optional type
    - excludeArchived - System.Boolean
    - orgId - System.String: Org UUID.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - nameFilter - System.String
- Returns O365TeamConvChannelConnection.
### calendar
Details of the Exchange calendar pertaining to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Calendar.
### consumption
Display license consumption for M365 workloads.

- There is a single argument of type O365ConsumptionInput.
- Returns O365Consumption.
### groups
List of O365 Groups in the O365Org.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
    - snappableType - SnappableType: The type of workload.
- Returns O365GroupConnection.
### hasaccesstoobjects
HasAccessToO365Objects returns if user has access to any o365 objects.

- The hasaccesstoobjects subcommand takes no arguments.
- Returns HasAccessToO365ObjectsResp.
### license
Retrieve o365 licence details.

- There is a single argument of type list of System.Strings.
- Returns O365License.
### listapps
Lists the O365 apps.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - o365AppFilters - list of AppFilters: Filters for the O365 app listing.
    - o365AppSortByParam - AppSortByParam: Sort parameter for the O365 app listing.
- Returns O365AppConnection.
### mailbox
Details for the Microsoft Exchange mailbox corresponding to the workload ID.

- There is a single argument of type System.String.
- Returns O365Mailbox.
### mailboxes
List of Mailboxes in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365MailboxConnection.
### objectancestors
GetO365ObjectAncestors returns the ancestor object summaries for the
given object that the caller is implicitly authorized to view.

- There is a single argument of type System.String.
- Returns GetImplicitlyAuthorizedAncestorSummariesResponse.
### onedrive
Details for the OneDrive corresponding to the workload ID.

- There is a single argument of type System.String.
- Returns O365Onedrive.
### onedrives
List of Onedrives in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365OnedriveConnection.
### org
Details of the O365Org.

- There is a single argument of type System.String.
- Returns O365Org.
### orgatsnappablelevel
Details of the O365Org at snappable level, given the snappable type.

- There are 2 arguments.
    - fid - System.String: Rubrik UUID for the object.
    - snappableType - SnappableType: The type of the M365 workload.
- Returns O365Org.
### orgs
All O365 orgs for the account.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments. A value of 'None' represents the hierarchy of all workload types.
- Returns O365OrgConnection.
### orgstatuses
Returns the status of each O365 org the caller is authorized to view.

- The orgstatuses subcommand takes no arguments.
- Returns list of O365OrgInfos.
### orgsummaries
GetO365OrgSummaries returns the O365 organizations that the caller is
implicitly authorized to view.

- The orgsummaries subcommand takes no arguments.
- Returns GetImplicitlyAuthorizedObjectSummariesResponse.
### queryrecoveryanalysisresult
QueryO365RecoveryAnalysisResult retrieves the recovery analysis result from
GCS for a given taskchain ID. This provides per-user analysis of Exchange,
OneDrive, and SharePoint activity data.

- There is a single argument of type GetRecoveryAnalysisResultReq.
- Returns GetRecoveryAnalysisResultResp.
### serviceaccount
Gets the service account for the given org.

- There is a single argument of type System.String.
- Returns O365ServiceAccountStatusResp.
### servicestatus
Returns the service status of the O365 service running on MSFT server.

- There is a single argument of type System.String.
- Returns GetO365ServiceStatusResp.
### sharepointdrive
Details for the SharePoint drive corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365SharepointDrive.
### sharepointdrives
List of SharePoint drives (document libraries) in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filters.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365SharepointDriveConnection.
### sharepointlist
Details for the SharePoint list corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365SharepointList.
### sharepointlists
Paginated list of sharepoint lists in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filters.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365SharepointListConnection.
### sharepointobjectlist
Returns the sharepoint objects after filtering on the object types and
includeEntireHierarchy.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - objectTypeFilter - list of System.Strings: Types of objects to include.
    - fid - System.String: FID of the parent O365 org or SharePoint site.
    - includeEntireHierarchy - System.Boolean: If true, the entire hierarchy will be searched.
- Returns O365SharepointObjectConnection.
### sharepointobjects
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - fid - System.String: Rubrik UUID for the object.
- Returns O365SharepointObjectConnection.
### sharepointobjectsnew
Loads and persists the SharePoint site hierarchy from Microsoft, then
returns the SharePoint objects under the given parent, filtered by object
type.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - objectTypeFilter - list of System.Strings: Types of objects to include.
    - includeEntireHierarchy - System.Boolean: Whether to include the entire hierarchy.
    - fid - System.String: The FID of the parent O365Org or O365Site.
- Returns O365SharepointObjectConnection.
### sharepointsite
Details for the SharePoint site corresponding to the site ID.

- There is a single argument of type System.String.
- Returns O365Site.
### sharepointsites
Paginated list of sharepoint sites in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365SiteConnection.
### site
Details for the SharePoint site corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Site.
### sites
List of SharePoint sites in the O365Org. When exclude_child_sites is true,
only direct child sites of the org are returned; otherwise all descendant
sites are returned.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
    - excludeChildSites - System.Boolean: When excludeChildSites is set to true, nested child sites are excluded from the results. If not specified, nested child sites are included.
- Returns O365SiteConnection.
### storagestats
Returns the storage stats of an O365 org.

- There is a single argument of type System.String.
- Returns GetO365StorageStatsResp.
### subscriptionsapptypecounts
Returns the total number of apps of each type for each O365 subscription,
aggregated across all apps in the account.

- The subscriptionsapptypecounts subcommand takes no arguments.
- Returns list of O365SubscriptionAppTypeCountss.
### team
Details for the team corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Teams.
### teamchannels
GetTeamChannelsV2 returns a paginated, GraphQL-shaped list of channels for
a Teams workload. Encapsulates the response shaping (TeamChannelInfo ->
O365TeamsChannelObject, including the membership-type enum parse) that
previously lived in the GraphQL resolver `o365TeamChannels`.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the Teams workload.
    - excludeArchived - System.Boolean: Whether archived channels are omitted.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - nameFilter - System.String: Optional display-name substring filter.
- Returns O365TeamsChannelConnection.
### teamconversationsfolderid
ID for the conversations folder in the Team's Group Mailbox.

- There are 3 arguments.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns System.String.
### teampostedby
SearchTeamPostSenders returns the users who have posted in the given
Teams workload, paginated.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the Teams workload.
    - o365OrgId - System.String: The FID for the O365 organization.
    - nameFilter - System.String: Optional display-name filter for post senders.
- Returns O365TeamConversationsSenderConnection.
### teams
List of O365 Teams in the O365Org.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
- Returns O365TeamsConnection.
### user
Details for the O365 user corresponding to the ID.

- There is a single argument of type System.String.
- Returns O365User.
### userobjects
Name, id, object type, and mail address of user descendant object.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - fid - System.String: Rubrik UUID for the object.
- Returns O365UserDescendantMetadataConnection.
### userselfserviceinfo
GetSelfServiceInfoForCurrentUser returns the self service info for the
currently logged-in user, including the user's name, OneDrive ID, and
mailbox ID (if they exist).

- The userselfserviceinfo subcommand takes no arguments.
- Returns GetSelfServiceInfoForUserResp.
