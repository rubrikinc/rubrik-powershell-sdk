# New-RscQueryHost
## Subcommands
### diagnosis
Get host availability statuses

Supported in v5.0+
Retrieve the availability status for each host registered with a specified Rubrik CDM instance.

- There is a single argument of type System.String.
- Returns HostDiagnosisSummary.
### failovergroup
Get all hosts for a given failover group.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - failoverGroupId - System.String: Failover group ID to get hosts for.
    - filter - FailoverGroupHostFilter: Filters to apply to the query.
- Returns FailoverGroupHostConnection.
### physicalhost
- There is a single argument of type System.String.
- Returns PhysicalHost.
### physicalhosts
Get list of physical hosts.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - hostRoot - HostRoot: Host root type.
    - isBulkPolicyAssignmentFlow - System.Boolean: Bulk policy assignment request.
- Returns PhysicalHostConnection.
### rbsnetworklimit
Get RBS network throttle limits for a host.

- There is a single argument of type System.String.
- Returns GetHostRbsNetworkThrottleResponse.
### search
- There are 2 arguments.
    - id - System.String: ID of the host to search.
    - path - System.String: The path query. Either path prefix or filename prefix.
- Returns SearchResponseListResponse.
### share
- There is a single argument of type System.String.
- Returns HostShare.
### shares
Get all host shares.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns HostShareConnection.
