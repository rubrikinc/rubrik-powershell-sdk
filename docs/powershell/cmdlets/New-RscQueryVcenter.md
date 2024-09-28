# New-RscQueryVcenter
## Subcommands
### advancedtagpreview
Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
v7.0-v9.1: Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.
v9.2+: Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh. It is not supported on Standalone Hosts.

- There is a single argument of type PreviewFilterInput.
- Returns VcenterAdvancedTagPreviewReply.
### asyncrequeststatus
Get async status of vcenter request.

- There is a single argument of type VcenterAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### hotaddbandwidth
Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- There is a single argument of type GetHotAddBandwidthInput.
- Returns HotAddBandwidthInfo.
### hotaddnetwork
Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- There is a single argument of type GetHotAddNetworkInput.
- Returns HotAddNetworkConfigWithName.
### hotaddproxy
Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.

- There is a single argument of type list of System.Strings.
- Returns list of VcenterHotAddProxyVmInfos.
### hotaddproxyvmsv2
Retrieve HotAdd proxy virtual machines.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - list of VcenterProxyVmsFilterInputs: Filter for vCenter hotadd proxy virtual machine.
    - clusterUuids - list of System.Strings: List of cluster IDs.
- Returns VsphereProxyVmInfoConnection.
### list
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVcenterConnection.
### networks
Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.

- There is a single argument of type GetNetworksInput.
- Returns NetworkInfoListResponse.
### numproxiesneeded
Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.

- There is a single argument of type GetNumProxiesNeededInput.
- Returns System.Int32.
### preaddinfo
Get preAddInfo for a vcenter.

- There is a single argument of type PreAddVcenterInput.
- Returns VcenterPreAddInfo.
### vcenter
- There is a single argument of type System.String.
- Returns VsphereVcenter.
