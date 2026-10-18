# New-RscQueryVsphere
## Subcommands
### computecluster
Details of the vSphere compute cluster with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereComputeCluster.
### computeclusters
Query compute clusters

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereComputeClusterConnection.
### datacenter
Details of the vSphere datacenter with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereDatacenter.
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

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereDatastoreClusterConnection.
### datastorelist
Query vSphere datastores.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereDatastoreConnection.
### folder
Vsphere folder based on id passed in.

- There is a single argument of type System.String.
- Returns VsphereFolder.
### folders
Get all the vSphere folders.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereFolderConnection.
### host
Details of the vSphere host with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereHost.
### hostdetails
Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.

- There is a single argument of type GetVmwareHostInput.
- Returns VmwareHostDetail.
### hostlist
Query vSphere hosts.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VsphereHostConnection.
### hostsbyfids
All of the VSphere hosts based on fids passed in.

- There is a single argument of type list of System.Strings.
- Returns list of VsphereHosts.
### livemounts
List of vSphere Live Mounts.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filter - list of VsphereLiveMountFilterInputs: Filter for virtual machine Live Mounts.
    - sortBy - VsphereLiveMountSortBy: Sort virtual machine Live Mounts.
- Returns VsphereLiveMountConnection.
### mount
Get a vSphere Live Mount by id

- There is a single argument of type System.String.
- Returns VsphereMount.
### mountlist
vSphere Live Mount Connection

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filter - VSphereMountFilter: Filter for virtual machine Live Mounts.
    - sortBy - VsphereMountSortBy: Sort virtual machine Live Mounts.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns VsphereMountConnection.
### network
Details of the vSphere network with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereNetwork.
### resourcepool
Details of a vSphere resource pool for a given ID.

- There is a single argument of type System.String.
- Returns VsphereResourcePool.
### resourcepoolwithprovisiononinfrastructure
Returns a single vSphere resource pool that is to be used as a recovery compute resource. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation. This is a short-term approach for solving RBAC issues with a previous datastore that was not auto-selected during the export workflow with low inventory view permission.

- There is a single argument of type System.String.
- Returns VsphereResourcePool.
### rootrecoveryhierarchy
The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### tag
Details of the vSphere tag with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereTag.
### tagcategory
Details of the vSphere tag category with the given Rubrik ID.

- There is a single argument of type System.String.
- Returns VsphereTagCategory.
### topleveldescendantslist
Paginated list of the vSphere objects immediately below the vSphere
inventory root.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### toplevelrecoverytargets
Returns the top level recovery targets for vSphere.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### vmsbyfids
All vSphere virtual machines, based on the FIDs passed.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns VsphereVmConnection.
### vmwarecdpliveinfo
- There is a single argument of type list of System.Strings.
- Returns BatchVmwareCdpLiveInfo.
