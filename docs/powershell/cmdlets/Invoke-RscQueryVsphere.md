# Invoke-RscQueryVsphere
## Subcommands
### Blueprint
- There is a single argument of type System.String.
- Returns VSphereBlueprint.
### Computecluster
- There is a single argument of type System.String.
- Returns VsphereComputeCluster.
### Datacenter
- There is a single argument of type System.String.
- Returns VsphereDatacenter.
### Datastore
Vsphere datastore based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereDatastore.
### Datastorecluster
Vsphere datastore cluster based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereDatastoreCluster.
### Datastoreconnection
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereDatastoreConnection.
### Folder
- There is a single argument of type System.String.
- Returns VsphereFolder.
### Host
- There is a single argument of type System.String.
- Returns VsphereHost.
### Hostconnection
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereHostConnection.
### Hostdetail
Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.

- There is a single argument of type GetVmwareHostInput.
- Returns VmwareHostDetail.
### Hostsbyfid
All of the VSphere hosts based on fids passed in.

- There is a single argument of type list of System.Strings.
- Returns list of VsphereHosts.
### Livemount
List of vSphere Live Mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - list of VsphereLiveMountFilterInputs: Filter for virtual machine Live Mounts.
    - sortBy - VsphereLiveMountSortBy: Sort virtual machine Live Mounts.
- Returns VsphereLiveMountConnection.
### Mount
Get a vSphere Live Mount by id

- There is a single argument of type System.String.
- Returns VsphereMount.
### Mountconnection
vSphere Live Mount Connection

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - VSphereMountFilter: Filter for virtual machine Live Mounts.
    - sortBy - VsphereMountSortBy
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereMountConnection.
### Network
- There is a single argument of type System.String.
- Returns VsphereNetwork.
### Resourcepool
- There is a single argument of type System.String.
- Returns VsphereResourcePool.
### Rootrecoveryhierarchy
The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### Tag
- There is a single argument of type System.String.
- Returns VsphereTag.
### Tagcategory
- There is a single argument of type System.String.
- Returns VsphereTagCategory.
### Topleveldescendantsconnection
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### Vmwarecdpliveinfo
- There is a single argument of type list of System.Strings.
- Returns BatchVmwareCdpLiveInfo.
