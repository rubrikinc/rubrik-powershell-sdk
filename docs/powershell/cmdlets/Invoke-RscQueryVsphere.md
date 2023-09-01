# Invoke-RscQueryVsphere
## Subcommands
### blueprint
- There is a single argument of type System.String.
- Returns VSphereBlueprint.
### computecluster
- There is a single argument of type System.String.
- Returns VsphereComputeCluster.
### computeclusters
Query compute clusters

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereComputeClusterConnection.
### datacenter
- There is a single argument of type System.String.
- Returns VsphereDatacenter.
### datacenterfolder
Vsphere datacenter folder based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereDatacenterFolder.
### datastore
Vsphere datastore based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereDatastore.
### datastorecluster
Vsphere datastore cluster based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereDatastoreCluster.
### datastoreclusters
Query vSphere datastore clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereDatastoreClusterConnection.
### datastorelist
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereDatastoreConnection.
### folder
- There is a single argument of type System.String.
- Returns VsphereFolder.
### folders
Get all the vSphere folders.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereFolderConnection.
### host
- There is a single argument of type System.String.
- Returns VsphereHost.
### hostdetails
Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.

- There is a single argument of type GetVmwareHostInput.
- Returns VmwareHostDetail.
### hostlist
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereHostConnection.
### hostsbyfids
All of the VSphere hosts based on fids passed in.

- There is a single argument of type list of System.Strings.
- Returns list of VsphereHosts.
### livemounts
List of vSphere Live Mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - list of VsphereLiveMountFilterInputs: Filter for virtual machine Live Mounts.
    - sortBy - VsphereLiveMountSortBy: Sort virtual machine Live Mounts.
- Returns VsphereLiveMountConnection.
### mount
Get a vSphere Live Mount by id

- There is a single argument of type System.String.
- Returns VsphereMount.
### mountlist
vSphere Live Mount Connection

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - VSphereMountFilter: Filter for virtual machine Live Mounts.
    - sortBy - VsphereMountSortBy
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereMountConnection.
### network
- There is a single argument of type System.String.
- Returns VsphereNetwork.
### resourcepool
- There is a single argument of type System.String.
- Returns VsphereResourcePool.
### rootrecoveryhierarchy
The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### tag
- There is a single argument of type System.String.
- Returns VsphereTag.
### tagcategory
- There is a single argument of type System.String.
- Returns VsphereTagCategory.
### topleveldescendantslist
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### vmwarecdpliveinfo
- There is a single argument of type list of System.Strings.
- Returns BatchVmwareCdpLiveInfo.
