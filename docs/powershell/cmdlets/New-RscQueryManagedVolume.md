# New-RscQueryManagedVolume
## Subcommands
### inventorystats
Aggregated inventory information for Managed Volume.

- The inventorystats subcommand takes no arguments.
- Returns ManagedVolumeInventoryStats.
### livemounts
Paginated list of Live Mounts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ManagedVolumeMountConnection.
### managedvolume
Details of a Managed Volume Object.

- There is a single argument of type System.String.
- Returns ManagedVolume.
### managedvolumes
Paginated list of Managed Volumes.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ManagedVolumeConnection.
