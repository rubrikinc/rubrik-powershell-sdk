# Invoke-RscQueryVsphere
## Subcommands
### Blueprint
- The Input parameter takes a single value of type System.String.
- Returns VSphereBlueprint.
### ComputeCluster
- The Input parameter takes a single value of type System.String.
- Returns VsphereComputeCluster.
### Datacenter
- The Input parameter takes a single value of type System.String.
- Returns VsphereDatacenter.
### Datastore
Vsphere datastore based on id passed in.

- The Input parameter takes a single value of type System.String.
- Returns VsphereDatastore.
### DatastoreCluster
Vsphere datastore cluster based on id passed in.

- The Input parameter takes a single value of type System.String.
- Returns VsphereDatastoreCluster.
### DatastoreList
- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereDatastoreConnection.
### Folder
- The Input parameter takes a single value of type System.String.
- Returns VsphereFolder.
### Host
- The Input parameter takes a single value of type System.String.
- Returns VsphereHost.
### HostDetail
Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.

- The Input parameter takes a single value of type GetVmwareHostInput.
- Returns VmwareHostDetail.
### HostList
- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereHostConnection.
### HostsByFid
All of the VSphere hosts based on fids passed in.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of VsphereHosts.
### LiveMount
List of vSphere Live Mounts.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of VsphereLiveMountFilterInputs: Filter for virtual machine Live Mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - VsphereLiveMountSortBy: Sort virtual machine Live Mounts.
- Returns VsphereLiveMountConnection.
### Mount
Get a vSphere Live Mount by id

- The Input parameter takes a single value of type System.String.
- Returns VsphereMount.
### MountList
vSphere Live Mount Connection

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - VSphereMountFilter: Filter for virtual machine Live Mounts.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - VsphereMountSortBy
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereMountConnection.
### Network
- The Input parameter takes a single value of type System.String.
- Returns VsphereNetwork.
### ResourcePool
- The Input parameter takes a single value of type System.String.
- Returns VsphereResourcePool.
### RootRecoveryHierarchy
The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns CdmHierarchyObjectConnection.
### Tag
- The Input parameter takes a single value of type System.String.
- Returns VsphereTag.
### TagCategory
- The Input parameter takes a single value of type System.String.
- Returns VsphereTagCategory.
### TopLevelDescendantsList
- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns CdmHierarchyObjectConnection.
### VmwareCdpLiveInfo
- The Input parameter takes a single value of type a list of System.Strings.
- Returns BatchVmwareCdpLiveInfo.
