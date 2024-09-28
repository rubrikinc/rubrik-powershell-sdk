# New-RscQueryGcpNative
## Subcommands
### disk
Get details of a GCP Disk

- There is a single argument of type System.String.
- Returns GcpNativeDisk.
### disks
List of GCP disks.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - GcpNativeDiskSortFields: Sort fields for list of GCP disks.
    - sortOrder - SortOrder: Sorts the order of results.
    - diskFilters - GcpNativeDiskFilters
- Returns GcpNativeDiskConnection.
### gceinstance
Get details of a GCE Instance

- There is a single argument of type System.String.
- Returns GcpNativeGceInstance.
### gceinstances
List of GCE instances.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - GcpNativeGceInstanceSortFields: Sort fields for list of GCP GCE instances.
    - sortOrder - SortOrder: Sorts the order of results.
    - gceInstanceFilters - GcpNativeGceInstanceFilters
- Returns GcpNativeGceInstanceConnection.
### project
Get details of a GCP Project

- There is a single argument of type System.String.
- Returns GcpNativeProject.
### projects
List of GCP projects.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - GcpNativeProjectSortFields: Sort fields for list of GCP projects.
    - sortOrder - SortOrder: Sorts the order of results.
    - projectFilters - GcpNativeProjectFilters
    - authorizedOperationFilter - Operation
    - workloadHierarchy - WorkloadLevelHierarchy: Provide optional workload hierarchy for RBAC and SLA, none value is assumed to be All workload hierarchy.
- Returns GcpNativeProjectConnection.
### storeddisklocations
lists distinct regions and zones of the GCP disks stored with Polaris

- There is a single argument of type System.String.
- Returns ListStoredDiskLocationsReply.
