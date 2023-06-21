# Invoke-RscQueryHyperv
## Subcommands
### Cluster
Details of the given Hyper-V Cluster.

- There is a single argument of type System.String.
- Returns HyperVCluster.
### Hostasyncrequeststatus
Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.

- There is a single argument of type GetHypervHostAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### Mount
HyperV Live Mount Connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of HypervLiveMountFilterInputs: Filter for hyper-v live mounts.
    - sortBy - HypervLiveMountSortByInput: Sort by argument for hyper-v live mounts.
- Returns HyperVLiveMountConnection.
### Scvmm
Details of the given Hyper-V SCVMM.

- There is a single argument of type System.String.
- Returns HyperVSCVMM.
### Scvmmasyncrequeststatus
Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.

- There is a single argument of type GetHypervScvmmAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### Server
Details of the given Hyper-V Server.

- There is a single argument of type System.String.
- Returns HypervServer.
### Topleveldescendant
Paginated list of the highest-level HyperV Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns HypervTopLevelDescendantTypeConnection.
### Uniqueserverscount
Count of unique HyperV Servers.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### Virtualmachine
Paginated list of HyperV Virtual Machines.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns HyperVVirtualMachineConnection.
### Virtualmachineasyncrequeststatus
Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.

- There is a single argument of type GetHypervVirtualMachineAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### Vmdetail
HyperV Virtual Machine detail from CDM.

- There is a single argument of type GetHypervVirtualMachineInput.
- Returns HypervVirtualMachineDetail.
