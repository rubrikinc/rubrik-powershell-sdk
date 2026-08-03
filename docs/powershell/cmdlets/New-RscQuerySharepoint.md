# New-RscQuerySharepoint
## Subcommands
### browsedrive
Browse SharePoint  drive files and folders.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
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
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - sharepointDriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### sitedescendants
Browse site and descendants objects.

BrowseSharepointSite returns SharePoint descendant objects directly
under a site (or a synthetic "root" entry when site_id is unset) for
a single snapshot. Mirrors the legacy sharepointSiteDescendants
resolver: rejects expired snapshots, drops
is_excluded_from_protection items, and -- when site_id is unset --
synthesizes a single root descendant decorated with quarantine
information using the snapshot-quarantine and snapshot-sequence
lookups.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - siteFid - System.String: Workload ID of SharePoint site object.
    - snapshotFid - System.String: Snapshot FID to browse inside.
    - naturalId - System.String: Optional SharePoint natural ID for the
folder being browsed. When unset, a synthetic root descendant is
returned.
    - sharepointSiteSearchFilter - SharePointSearchFilter: Optional SharePoint search filter.
    - orgId - System.String: Organization scope for the browse.
- Returns O365FullSpObjectConnection.
### siteexclusions
Sharepoint site objects excluded from protection.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - siteFids - list of System.Strings: List of site IDs. If none are provided, all the Sharepoint site exclusions are returned.
- Returns list of FullSpSiteExclusionss.
### sitesearch
Search site and descendant objects.

SearchSharepointSite returns a paginated, GraphQL-shaped list of
SharePoint descendant objects for the given site workload across
all snapshots. Encapsulates the response shaping (filter out
is_excluded_from_protection items per SPARK-151589) that previously
lived in the GraphQL resolver `sharepointSiteSearch`.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - siteFid - System.String: Workload ID of SharePoint site object.
    - orgId - System.String: Organization scope for the search.
    - sharepointSiteSearchFilter - SharePointSearchFilter: Optional SharePoint search filter.
- Returns O365FullSpObjectConnection.
### snappabledrivesearch
Returns SharePoint drive folders and files for the given site
workload across all snapshots, merged as a single O365OnedriveObject
interface list (folders then files).

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter: Optional SharePoint drive search filter.
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
    - siteChildType - SharePointDescendantType: The site child type for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### snappablelistsearch
Returns SharePoint list objects for the given site workload across
all snapshots, merged as a single O365OnedriveObject interface list
(folders then files).

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter: Optional SharePoint list search filter.
    - siteChildId - System.String: The site child ID for SharePoint descendant objects.
- Returns O365OnedriveObjectConnection.
### snapshotdrivesearch
Returns SharePoint drive folders and files inside a single snapshot,
merged as a single O365OnedriveObject interface list (folders then
files).

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - sharepointDriveSearchFilter - OnedriveSearchFilter: Optional SharePoint drive search filter.
- Returns O365OnedriveObjectConnection.
