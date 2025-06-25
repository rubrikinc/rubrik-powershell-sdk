# New-RscQueryVsphereVm
## Subcommands
### asyncrequeststatus
- There are 2 arguments.
    - clusterUuid - System.String
    - id - System.String: ID of an asynchronous request.
- Returns AsyncRequestStatus.
### missedrecoverablerange
- There are 3 arguments.
    - snappableFid - System.String: The ID of the workload.
    - beforeTime - DateTime
    - afterTime - DateTime
- Returns RecoverableRangeResponse.
### new
- There is a single argument of type System.String.
- Returns VsphereVm.
### newlist
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereVmConnection.
### recoverablerange
- There are 3 arguments.
    - snappableFid - System.String: The ID of the workload.
    - beforeTime - DateTime
    - afterTime - DateTime
- Returns RecoverableRangeResponse.
### recoverablerangeinbatch
- There is a single argument of type BatchVmwareVmRecoverableRangesRequestInput.
- Returns BatchVmwareVmRecoverableRanges.
### withprovisiononinfrastructure
Returns compute resources information for a single vsphere virtual machine to be used as a recovery source. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation. This is a short-term approach for solving RBAC issues where an org-user with view permission that is lower than hosts cannot have the same datastore auto-selected.

- There is a single argument of type System.String.
- Returns VsphereVm.
