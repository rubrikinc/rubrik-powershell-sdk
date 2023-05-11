# Invoke-RscQueryHyperv
## Subcommands
### Cluster
Details of the given Hyper-V Cluster.

- The Input parameter takes a single value of type System.String.
- Returns HyperVCluster.
### HostAsyncRequestStatus
Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.

- The Input parameter takes a single value of type GetHypervHostAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### Mount
HyperV Live Mount Connection.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - a list of HypervLiveMountFilterInputs: Filter for hyper-v live mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HypervLiveMountSortByInput: Sort by argument for hyper-v live mounts.
- Returns HyperVLiveMountConnection.
### Scvmm
Details of the given Hyper-V SCVMM.

- The Input parameter takes a single value of type System.String.
- Returns HyperVSCVMM.
### ScvmmAsyncRequestStatus
Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.

- The Input parameter takes a single value of type GetHypervScvmmAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### Server
Details of the given Hyper-V Server.

- The Input parameter takes a single value of type System.String.
- Returns HypervServer.
### TopLevelDescendant
Paginated list of the highest-level HyperV Objects accessible by the current user.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns HypervTopLevelDescendantTypeConnection.
### VirtualMachine
Details of the given Hyper-V Virtual Machine.

- The Input parameter takes a single value of type System.String.
- Returns HyperVVirtualMachine.
### VirtualMachineAsyncRequestStatus
Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.

- The Input parameter takes a single value of type GetHypervVirtualMachineAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### VmDetail
HyperV Virtual Machine detail from CDM.

- The Input parameter takes a single value of type GetHypervVirtualMachineInput.
- Returns HypervVirtualMachineDetail.
### uniqueServersCount
Count of unique HyperV Servers.

- The Input parameter takes a single value of type a list of Filters.
- Returns System.Int32.
