# Invoke-RscQueryO365
## Subcommands
### alladgroups
All AD Groups belonging to the O365 organization.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - adGroupSearchFilter - System.String: AD group search filter.
- Returns list of AdGroups.
### allorgstatuses
Gets the status of each org in the account.

- The allorgstatuses subcommand takes no arguments.
- Returns list of O365OrgInfos.
### allsubscriptionsapptypecounts
Returns the total number of apps of each type, for each O365 org.

- The allsubscriptionsapptypecounts subcommand takes no arguments.
- Returns list of O365SubscriptionAppTypeCountss.
### browseteamconvchannels
Browse channels in a Teams conversations snapshot.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
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
### groups
List of O365 Groups in the O365Org.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
    - snappableType - SnappableType
- Returns O365GroupConnection.
### license
Retrieve o365 licence details.

- The license subcommand takes no arguments.
- Returns O365License.
### listapps
Lists the O365 apps.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - o365AppFilters - list of AppFilters
    - o365AppSortByParam - AppSortByParam
- Returns O365AppConnection.
### mailbox
Details for the Exchange mailbox corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Mailbox.
### mailboxes
List of Mailboxes in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365MailboxConnection.
### objectancestors
- There is a single argument of type System.String.
- Returns GetImplicitlyAuthorizedAncestorSummariesResponse.
### onedrive
Details for the OneDrive corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Onedrive.
### onedrives
List of Onedrives in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365OnedriveConnection.
### org
Details of the O365Org.

- There is a single argument of type System.String.
- Returns O365Org.
### orgatsnappablelevel
Details of the O365Org at snappable level, given the snappable type.

- There are 2 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - snappableType - SnappableType
- Returns O365Org.
### orgs
All O365 orgs for the account.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - workloadHierarchy - WorkloadLevelHierarchy: Each value in the enum represents the hierarchy of a specific type of protected object for RBAC and SLA Domain assignments. The value None represents the hierarchy of all types of objects.
- Returns O365OrgConnection.
### orgsummaries
- The orgsummaries subcommand takes no arguments.
- Returns GetImplicitlyAuthorizedObjectSummariesResponse.
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
List of sharepoint drives (document libraries) in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365SharepointDriveConnection.
### sharepointlist
Details for the SharePoint list corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365SharepointList.
### sharepointlists
Paginated list of sharepoint lists in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365SharepointListConnection.
### sharepointobjectlist
Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - objectTypeFilter - list of System.Strings: Types of objects to include.
    - includeEntireHierarchy - System.Boolean: If true, the entire hierarchy will be searched.
    - fid - System.String: The Rubrik UUID for the object.
- Returns O365SharepointObjectConnection.
### sharepointobjects
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - fid - System.String: The Rubrik UUID for the object.
- Returns O365SharepointObjectConnection.
### sharepointsite
Details for the SharePoint site corresponding to the site ID.

- There is a single argument of type System.String.
- Returns O365Site.
### sharepointsites
Paginated list of sharepoint sites in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365SiteConnection.
### site
Details for the SharePoint site corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Site.
### sites
List of sites in the O365Org.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
    - excludeChildSites - System.Boolean: If true, nested children sites will be excluded from the results.
- Returns O365SiteConnection.
### storagestats
Returns the storage stats of an O365 org.

- There is a single argument of type System.String.
- Returns GetO365StorageStatsResp.
### team
Details for the team corresponding to the snappable ID.

- There is a single argument of type System.String.
- Returns O365Teams.
### teamchannels
List of Channels for the O365Team.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - excludeArchived - System.Boolean
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - nameFilter - System.String
- Returns O365TeamsChannelConnection.
### teamconversationsfolderid
ID for the conversations folder in the Team's Group Mailbox.

- There are 3 arguments.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns System.String.
### teampostedby
Users who have posted in a team.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - o365OrgId - System.String: The fid for the O365 organization.
    - nameFilter - System.String
- Returns O365TeamConversationsSenderConnection.
### teams
List of O365 Teams in the O365Org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - o365OrgId - System.String: The fid for the O365 organization.
- Returns O365TeamsConnection.
### user
Details for the O365 user corresponding to the ID.

- There is a single argument of type System.String.
- Returns O365User.
### userobjects
Name, id, object type, and mail address of user descendant object.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - fid - System.String: The Rubrik UUID for the object.
- Returns O365UserDescendantMetadataConnection.
