# New-RscQuerySharepoint
## Subcommands
### browsedrive
Browse SharePoint  drive files and folders.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
    - siteChildType - SharePointDescendantType: The site child type for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### browselist
Browse list objects.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### sitedescendants
Browse site and descendants objects.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - siteFid - System.String: The fid for the site.
    - snapshotFid - System.String: The ID of the snapshot.
    - naturalId - System.String: The natural ID of SharePoint object.
    - sharepointSiteSearchFilter - SharePointSearchFilter: The filter for site search.
    - orgId - System.String: Org UUID.
- Returns O365FullSpObjectConnection.
### siteexclusions
Sharepoint site objects excluded from protection.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - siteFids - list of System.Strings: List of site IDs. If none are provided, all the Sharepoint site exclusions are returned.
- Returns list of FullSpSiteExclusionss.
### sitesearch
Search site and descendant objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - siteFid - System.String: The fid for the site.
    - orgId - System.String: Org UUID.
    - sharepointSiteSearchFilter - SharePointSearchFilter: The filter for site search.
- Returns O365FullSpObjectConnection.
### snappabledrivesearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
    - siteChildType - SharePointDescendantType: The site child type for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### snappablelistsearch
Search list objects.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### snapshotdrivesearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
