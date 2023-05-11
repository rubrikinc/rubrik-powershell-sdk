# Invoke-RscMutateVcenter
## Subcommands
### Create
Add a vCenter server.

- The Input parameter takes a single value of type CreateVsphereVcenterInput.
- Returns CreateVsphereVcenterReply.
### Delete
Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.

- The Input parameter takes a single value of type VsphereDeleteVcenterInput.
- Returns AsyncRequestStatus.
### Edit
- The Input parameter takes a hashtable with 6 name and value pairs.
    - caCert - System.String
    - conflictResolutionAuthz - ConflictResolutionAuthzEnum
    - hostname - System.String
    - password - System.String
    - username - System.String
    - vcenterId - System.String
- Returns RequestSuccess.
### Refresh
Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.

- The Input parameter takes a single value of type RefreshVsphereVcenterInput.
- Returns AsyncRequestStatus.
### update
Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.

- The Input parameter takes a single value of type UpdateVcenterInput.
- Returns UpdateVcenterReply.
### updateHotAddBandwidth
Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- The Input parameter takes a single value of type UpdateVcenterHotAddBandwidthInput.
- Returns RequestSuccess.
### updateHotAddNetwork
Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- The Input parameter takes a single value of type UpdateVcenterHotAddNetworkInput.
- Returns RequestSuccess.
