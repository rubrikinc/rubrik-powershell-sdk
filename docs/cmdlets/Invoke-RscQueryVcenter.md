# Invoke-RscQueryVcenter
## Subcommands
### AdvancedTagPreview
Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.

- The Input parameter takes a single value of type PreviewFilterInput.
- Returns VcenterAdvancedTagPreviewReply.
### HotAddBandwidth
Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- The Input parameter takes a single value of type GetHotAddBandwidthInput.
- Returns HotAddBandwidthInfo.
### HotAddNetwork
Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- The Input parameter takes a single value of type GetHotAddNetworkInput.
- Returns HotAddNetworkConfigWithName.
### HotAddProxy
Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of VcenterHotAddProxyVmInfos.
### List
- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns VsphereVcenterConnection.
### Network
Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.

- The Input parameter takes a single value of type GetNetworksInput.
- Returns NetworkInfoListResponse.
### NumProxiesNeeded
Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.

- The Input parameter takes a single value of type GetNumProxiesNeededInput.
- Returns System.Int32.
### PreAddInfo
Get preAddInfo for a vcenter.

- The Input parameter takes a single value of type PreAddVcenterInput.
- Returns VcenterPreAddInfo.
### Vcenter
- The Input parameter takes a single value of type System.String.
- Returns VsphereVcenter.
### uniqueCount
- The Input parameter takes a single value of type a list of Filters.
- Returns System.Int32.
