# New-RscQueryActiveDirectory
## Subcommands
### asyncrequeststatus
Retrieve the status of an Active Directory job request.

- There is a single argument of type ActiveDirectoryAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### domain
Summary of the given Active Directory domain.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomain.
### domaincontroller
Summary of the given Active Directory domain controller.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomainController.
### domaincontrollers
Summary of all Active Directory domain controllers.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryDomainControllerConnection.
### domains
Summary of all Active Directory domains.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryDomainConnection.
### forests
Summary of all the Active Directory forest.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryForestConnection.
### objectdiff
Get the difference between attributes in Active Directory (AD) objects between two snapshots or against live AD.

- There are 6 arguments.
    - dnt - System.Int32: The Distinguished Name Tag (DNT) of the Active Directory object which would be used for calculating the diff.
    - snapshotId1 - System.String: Snapshot of the Active Directory domain controller from which the object's attributes would be compared with the another snapshot. This should be 00000000-0000-0000-0000-000000000000 in case comparison has to be done with live AD.
    - snapshotId2 - System.String: Snapshot of the Active Directory domain controller from which the object's attributes would be compared with the another snapshot. This should be 00000000-0000-0000-0000-000000000000 in case comparison has to be done with live AD.
    - attributes - list of System.Strings: Only return attributes specified in this field.
    - shouldReportOnlyChangedAttrs - System.Boolean: Specifies whether to report only attributes whose values have changed.
    - shouldReportOnlyChangedValues - System.Boolean: Specifies whether to report only changed values for an attribute in the object diff.
- Returns ActiveDirectoryObjectAttributesDiffResponseListResponse.
### searchsnapshots
Search across a range of snapshots of a domain controller for Active Directory objects

Supported in v9.1+
Return the Active Directory objects matching the search criteria.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - id - System.String: ID of the Active Directory domain controller that needs to be explored.
    - snapshotAfterDate - DateTime: Searches across the snapshots taken on or after the specified date.
    - snapshotBeforeDate - DateTime: Searches across the snapshots taken on or before the specified date.
    - name - System.String: Search string.
    - activeDirectoryObjectType - ActiveDirectoryObjectType: The supported Active Directory object types.
- Returns ActiveDirectorySnappableSearchResponseConnection.
### snapshotbrowse
Browse the snapshot for an Active Directory Domain Controller

Supported in v9.0+
v9.0: Given a parent object identifier dnt (Distinguished Name Tag), list all the children associated with the parent.
v9.1+: Given a parent object identifier known as Distinguished Name Tag (DNT), list all the children associated with the parent.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - id - System.String: The ID of the snapshot that needs to be explored.
    - dnt - System.Int32: v9.0: The identifier of the object for which the children need to be listed.
  v9.1+: The Distinguished Name Tag (DNT) of the Active Directory object for which you want to list the children.
    - listOnlyContainers - System.Boolean: v9.0: List only containers while enumerating an object.
  v9.1+: List only the containers when listing the objects.
    - activeDirectoryObjectType - ActiveDirectoryObjectType: The supported Active Directory object types.
    - locationId - System.String: ID of the archival or replication location.
- Returns ActiveDirectorySnapshotBrowseConnection.
### snapshotsearch
Search the snapshot for Active Directory objects

Supported in v9.0+
v9.0: When a parent object identifier distinguished name tag (DNT) is specified, list all the children associated with the parent matching the search criteria.
v9.1+: Return the Active Directory objects matching the search criteria.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - id - System.String: ID of the snapshot that needs to be explored.
    - dnt - System.Int32: Identifier of the object under which objects with matching search criteria must be returned.
    - attribute - System.String: The attribute whose value needs to be searched. Default is display name.
    - activeDirectoryObjectType - ActiveDirectoryObjectType: The supported Active Directory object types.
    - name - System.String: Search string.
    - locationId - System.String: ID of the archival or replication location.
- Returns ActiveDirectorySnapshotBrowseConnection.
### unifieddomain
Consolidated summary of the given Active Directory domain across Rubrik clusters.

- There are 2 arguments.
    - domainFid - System.String: Domain FID of the Active Directory domain to search.
    - domainSid - System.String: Domain SID of the Active Directory domain to search.
- Returns UnifiedActiveDirectoryDomain.
### unifieddomaincontrollers
Consolidated summary of all Active Directory domain controllers across Rubrik clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryDomainControllerConnection.
### unifieddomains
Consolidated summary of all Active Directory domains across Rubrik clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns UnifiedActiveDirectoryDomainConnection.
### unifiedforests
Consolidated summary of all the Active Directory forest across Rubrik clusters.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
- Returns UnifiedActiveDirectoryForestConnection.
