# Invoke-RscQueryNutanix
## Subcommands
### BrowseSnapshot
v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.

- The Input parameter takes a single value of type BrowseNutanixSnapshotInput.
- Returns BrowseResponseListResponse.
### Cluster
A Nutanix Cluster.

- The Input parameter takes a single value of type System.String.
- Returns NutanixCluster.
### ClusterAsyncRequestStatus
Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.

- The Input parameter takes a single value of type GetNutanixClusterAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### ClusterContainer
Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.

- The Input parameter takes a single value of type GetContainersInput.
- Returns NutanixContainerListResponse.
### ClusterNetwork
Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.

- The Input parameter takes a single value of type GetNutanixNetworksInput.
- Returns NutanixNetworkListResponse.
### Mount
Nutanix Live Mount Connection.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - a list of NutanixLiveMountFilterInputs: Filter for Nutanix virtual machine live mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - NutanixLiveMountSortByInput: Sort by argument for Nutanix virtual machine live mounts.
- Returns NutanixLiveMountConnection.
### PrismCentral
Paginated list of Nutanix Prism Central objects.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns NutanixPrismCentralConnection.
### SnapshotDetail
Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.

- The Input parameter takes a single value of type GetNutanixSnapshotDetailInput.
- Returns NutanixVmSnapshotDetail.
### TopLevelDescendant
Paginated list of the highest-level Nutanix Objects accessible by the current user.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns CdmHierarchyObjectConnection.
### TopLevelDescendantsV2
Paginated list of the highest-level Nutanix Objects accessible by the current user.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns NutanixTopLevelDescendantTypeConnection.
### Vm
A Nutanix Virtual Machine.

- The Input parameter takes a single value of type System.String.
- Returns NutanixVm.
### VmAsyncRequestStatus
v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.

- The Input parameter takes a single value of type GetNutanixVmAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### VmMissedSnapshot
v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.

- The Input parameter takes a single value of type NutanixMissedSnapshotsInput.
- Returns MissedSnapshotListResponse.
### searchVm
v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.

- The Input parameter takes a single value of type SearchNutanixVmInput.
- Returns SearchResponseListResponse.
