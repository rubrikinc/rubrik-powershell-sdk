# New-RscQueryNutanix
## Subcommands
### browsesnapshot
v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.

- There is a single argument of type BrowseNutanixSnapshotInput.
- Returns BrowseResponseListResponse.
### category
Details of the given category.

- There is a single argument of type System.String.
- Returns NutanixCategory.
### categoryvalue
Details of the given category value.

- There is a single argument of type System.String.
- Returns NutanixCategoryValue.
### cluster
A Nutanix Cluster.

- There is a single argument of type System.String.
- Returns NutanixCluster.
### clusterasyncrequeststatus
Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.

- There is a single argument of type GetNutanixClusterAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### clustercontainers
Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.

- There is a single argument of type GetContainersInput.
- Returns NutanixContainerListResponse.
### clusternetworks
Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.

- There is a single argument of type GetNutanixNetworksInput.
- Returns NutanixNetworkListResponse.
### clusters
Paginated list of Nutanix Clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NutanixClusterConnection.
### mounts
Nutanix Live Mount Connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - filters - list of NutanixLiveMountFilterInputs: Filter for Nutanix virtual machine live mounts.
    - sortBy - NutanixLiveMountSortByInput: Sort by argument for Nutanix virtual machine live mounts.
- Returns NutanixLiveMountConnection.
### mountsv2
Details of a Nutanix mount.

- There is a single argument of type GetNutanixMountsReq.
- Returns GetNutanixMountsReply.
### prismcentral
Details of the given Prism Central.

- There is a single argument of type System.String.
- Returns NutanixPrismCentral.
### prismcentrals
Paginated list of Nutanix Prism Central objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NutanixPrismCentralConnection.
### searchvm
v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.

- There is a single argument of type SearchNutanixVmInput.
- Returns SearchResponseListResponse.
### snapshotdetail
Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.

- There is a single argument of type GetNutanixSnapshotDetailInput.
- Returns NutanixVmSnapshotDetail.
### snapshotvdisks
Supported in v9.2+. Get virtual disks from Nutanix virtual machine snapshot.
 Retrieve detailed information about the virtual disks.

- There is a single argument of type GetNutanixVmSnapshotVdisksInput.
- Returns NutanixVmSnapshotVdiskDetailListResponse.
### topleveldescendants
Paginated list of the highest-level Nutanix Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### vdiskmountablevms
A paginated list of Nutanix virtual machines with the vDisk Mount privilege.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NutanixVmConnection.
### vm
A Nutanix Virtual Machine.

- There is a single argument of type System.String.
- Returns NutanixVm.
### vmasyncrequeststatus
v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.

- There is a single argument of type GetNutanixVmAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### vmmissedsnapshots
v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.

- There is a single argument of type NutanixMissedSnapshotsInput.
- Returns MissedSnapshotListResponse.
### vms
Paginated list of Nutanix Virtual Machines.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NutanixVmConnection.
