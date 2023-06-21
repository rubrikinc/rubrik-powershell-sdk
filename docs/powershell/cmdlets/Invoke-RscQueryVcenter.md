# Invoke-RscQueryVcenter
## Subcommands
### Advancedtagpreview
Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.

- There is a single argument of type PreviewFilterInput.
- Returns VcenterAdvancedTagPreviewReply.
### Hotaddbandwidth
Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- There is a single argument of type GetHotAddBandwidthInput.
- Returns HotAddBandwidthInfo.
### Hotaddnetwork
Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- There is a single argument of type GetHotAddNetworkInput.
- Returns HotAddNetworkConfigWithName.
### Hotaddproxy
Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.

- There is a single argument of type list of System.Strings.
- Returns list of VcenterHotAddProxyVmInfos.
### List
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVcenterConnection.
### Network
Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.

- There is a single argument of type GetNetworksInput.
- Returns NetworkInfoListResponse.
### Numproxiesneeded
Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.

- There is a single argument of type GetNumProxiesNeededInput.
- Returns System.Int32.
### Preaddinfo
Get preAddInfo for a vcenter.

- There is a single argument of type PreAddVcenterInput.
- Returns VcenterPreAddInfo.
### Uniquecount
- There is a single argument of type list of Filters.
- Returns System.Int32.
### Vcenter
- There is a single argument of type System.String.
- Returns VsphereVcenter.
