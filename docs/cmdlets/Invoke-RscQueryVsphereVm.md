# Invoke-RscQueryVsphereVm
## Subcommands
### AsyncRequestStatus
- The Input parameter takes a hashtable with 2 name and value pairs.
    - clusterUuid - System.String
    - id - System.String: ID of an asynchronous request.
- Returns AsyncRequestStatus.
### MissedRecoverableRange
- The Input parameter takes a hashtable with 3 name and value pairs.
    - afterTime - DateTime
    - beforeTime - DateTime
    - snappableFid - System.String
- Returns RecoverableRangeResponse.
### New
- The Input parameter takes a single value of type System.String.
- Returns VsphereVm.
### NewList
- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereVmConnection.
### RecoverableRange
- The Input parameter takes a hashtable with 3 name and value pairs.
    - afterTime - DateTime
    - beforeTime - DateTime
    - snappableFid - System.String
- Returns RecoverableRangeResponse.
### RecoverableRangeInBatch
- The Input parameter takes a single value of type BatchVmwareVmRecoverableRangesRequestInput.
- Returns BatchVmwareVmRecoverableRanges.
