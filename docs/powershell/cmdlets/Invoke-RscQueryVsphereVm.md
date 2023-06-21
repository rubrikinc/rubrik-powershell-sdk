# Invoke-RscQueryVsphereVm
## Subcommands
### Asyncrequeststatus
- There are 2 arguments.
    - clusterUuid - System.String
    - id - System.String: ID of an asynchronous request.
- Returns AsyncRequestStatus.
### Missedrecoverablerange
- There are 3 arguments.
    - snappableFid - System.String
    - beforeTime - DateTime
    - afterTime - DateTime
- Returns RecoverableRangeResponse.
### New
- There is a single argument of type System.String.
- Returns VsphereVm.
### Newconnection
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVmConnection.
### Recoverablerange
- There are 3 arguments.
    - snappableFid - System.String
    - beforeTime - DateTime
    - afterTime - DateTime
- Returns RecoverableRangeResponse.
### Recoverablerangeinbatch
- There is a single argument of type BatchVmwareVmRecoverableRangesRequestInput.
- Returns BatchVmwareVmRecoverableRanges.
