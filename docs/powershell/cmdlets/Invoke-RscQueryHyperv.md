# Invoke-RscQueryHyperv
## Subcommands
### cluster
Details of the given Hyper-V Cluster.

- There is a single argument of type System.String.
- Returns HyperVCluster.
### hostasyncrequeststatus
Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.

- There is a single argument of type GetHypervHostAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### mount
HyperV Live Mount Connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of HypervLiveMountFilterInputs: Filter for hyper-v live mounts.
    - sortBy - HypervLiveMountSortByInput: Sort by argument for hyper-v live mounts.
- Returns HyperVLiveMountConnection.
### scvmm
Details of the given Hyper-V SCVMM.

- There is a single argument of type System.String.
- Returns HyperVSCVMM.
### scvmmasyncrequeststatus
Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.

- There is a single argument of type GetHypervScvmmAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### server
Details of the given Hyper-V Server.

- There is a single argument of type System.String.
- Returns HypervServer.
### topleveldescendant
Paginated list of the highest-level HyperV Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns HypervTopLevelDescendantTypeConnection.
### uniqueserverscount
Count of unique HyperV Servers.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### virtualmachine
Paginated list of HyperV Virtual Machines.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns HyperVVirtualMachineConnection.
### virtualmachineasyncrequeststatus
Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.

- There is a single argument of type GetHypervVirtualMachineAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### vmdetail
HyperV Virtual Machine detail from CDM.

- There is a single argument of type GetHypervVirtualMachineInput.
- Returns HypervVirtualMachineDetail.
