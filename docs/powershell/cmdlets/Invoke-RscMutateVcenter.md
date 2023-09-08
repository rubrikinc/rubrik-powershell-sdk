# Invoke-RscMutateVcenter
## Subcommands
### create
Add a vCenter server.

- There is a single argument of type CreateVsphereVcenterInput.
- Returns CreateVsphereVcenterReply.
### delete
Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.

- There is a single argument of type VsphereDeleteVcenterInput.
- Returns AsyncRequestStatus.
### refresh
Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.

- There is a single argument of type RefreshVsphereVcenterInput.
- Returns AsyncRequestStatus.
### update
Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.

- There is a single argument of type UpdateVcenterInput.
- Returns UpdateVcenterReply.
### updatehotaddbandwidth
Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- There is a single argument of type UpdateVcenterHotAddBandwidthInput.
- Returns RequestSuccess.
### updatehotaddnetwork
Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- There is a single argument of type UpdateVcenterHotAddNetworkInput.
- Returns RequestSuccess.
