# Invoke-RscQueryO365
## Subcommands
### Calendar
Details of the Exchange calendar pertaining to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Calendar.
### Group
List of O365 Groups in the O365Org.

- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - o365OrgId - System.String: The fid for the O365 organization.
    - snappableType - SnappableType
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns O365GroupConnection.
### License
Retrieve o365 licence details.

- The License subcommand takes no arguments.
- Returns O365License.
### Mailbox
Details for the Exchange mailbox corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Mailbox.
### Mailboxe
List of Mailboxes in the O365Org.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - o365OrgId - System.String: The fid for the O365 organization.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns O365MailboxConnection.
### ObjectAncestor
- The Input parameter takes a single value of type System.String.
- Returns GetImplicitlyAuthorizedAncestorSummariesResponse.
### Onedrive
Details for the OneDrive corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Onedrive.
### Org
Details of the O365Org.

- The Input parameter takes a single value of type System.String.
- Returns O365Org.
### OrgAtSnappableLevel
Details of the O365Org at snappable level, given the snappable type.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - fid - System.String: The Rubrik UUID for the object.
    - snappableType - SnappableType
- Returns O365Org.
### OrgSummarie
- The OrgSummarie subcommand takes no arguments.
- Returns GetImplicitlyAuthorizedObjectSummariesResponse.
### ServiceAccount
Gets the service account for the given org.

- The Input parameter takes a single value of type System.String.
- Returns O365ServiceAccountStatusResp.
### ServiceStatus
Returns the service status of the O365 service running on MSFT server.

- The Input parameter takes a single value of type System.String.
- Returns GetO365ServiceStatusResp.
### SharepointDrive
Details for the SharePoint drive corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365SharepointDrive.
### SharepointList
Details for the SharePoint list corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365SharepointList.
### SharepointObject
- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - fid - System.String: The Rubrik UUID for the object.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns O365SharepointObjectConnection.
### SharepointObjectList
Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.

- The Input parameter takes a hashtable with 8 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - fid - System.String: The Rubrik UUID for the object.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - includeEntireHierarchy - System.Boolean: If true, the entire hierarchy will be searched.
    - objectTypeFilter - a list of System.Strings: Types of objects to include.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns O365SharepointObjectConnection.
### SharepointSite
Details for the SharePoint site corresponding to the site ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Site.
### Site
Details for the SharePoint site corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Site.
### StorageStat
Returns the storage stats of an O365 org.

- The Input parameter takes a single value of type System.String.
- Returns GetO365StorageStatsResp.
### Team
Details for the team corresponding to the snappable ID.

- The Input parameter takes a single value of type System.String.
- Returns O365Teams.
### TeamChannel
List of Channels for the O365Team.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - excludeArchived - System.Boolean
    - first - System.Int32: Returns the first n elements from the list.
    - nameFilter - System.String
    - snappableFid - System.String: The fid for the workload.
- Returns O365TeamsChannelConnection.
### TeamConversationsFolderID
ID for the conversations folder in the Team's Group Mailbox.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - o365OrgId - System.String: The fid for the O365 organization.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
- Returns System.String.
### TeamPostedBy
Users who have posted in a team.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - nameFilter - System.String
    - o365OrgId - System.String: The fid for the O365 organization.
    - snappableFid - System.String: The fid for the workload.
- Returns O365TeamConversationsSenderConnection.
### User
Details for the O365 user corresponding to the ID.

- The Input parameter takes a single value of type System.String.
- Returns O365User.
### UserObject
Name, id, object type, and mail address of user descendant object.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - fid - System.String: The Rubrik UUID for the object.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns O365UserDescendantMetadataConnection.
### allAdGroup
All AD Groups belonging to the O365 organization.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - adGroupSearchFilter - System.String: AD group search filter.
    - orgId - System.String: Org UUID.
- Returns a list of AdGroups.
### allOrgStatus
Gets the status of each org in the account.

- The allOrgStatus subcommand takes no arguments.
- Returns a list of O365OrgInfos.
### allSubscriptionsAppTypeCount
Returns the total number of apps of each type, for each O365 org.

- The allSubscriptionsAppTypeCount subcommand takes no arguments.
- Returns a list of O365SubscriptionAppTypeCountss.
### browseTeamConvChannel
Browse channels in a Teams conversations snapshot.

- The Input parameter takes a hashtable with 8 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - excludeArchived - System.Boolean
    - first - System.Int32: Returns the first n elements from the list.
    - nameFilter - System.String
    - orgId - System.String: Org UUID.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFidOpt - System.String: snapshotFid arg which is of optional type
- Returns O365TeamConvChannelConnection.
### listApp
Lists the O365 apps.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - o365AppFilters - a list of AppFilters
    - o365AppSortByParam - AppSortByParam
- Returns O365AppConnection.
