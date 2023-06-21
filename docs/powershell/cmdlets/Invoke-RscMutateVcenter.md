# Invoke-RscMutateVcenter
## Subcommands
### Create
- There are 6 arguments.
    - clusterUuid - System.String
    - hostname - System.String
    - username - System.String
    - password - System.String
    - conflictResolutionAuthz - ConflictResolutionAuthzEnum
    - caCert - System.String
- Returns VsphereAsyncRequestStatus.
### Delete
Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.

- There is a single argument of type VsphereDeleteVcenterInput.
- Returns AsyncRequestStatus.
### Edit
- There are 6 arguments.
    - vcenterId - System.String
    - hostname - System.String
    - username - System.String
    - password - System.String
    - conflictResolutionAuthz - ConflictResolutionAuthzEnum
    - caCert - System.String
- Returns RequestSuccess.
### Refresh
- There is a single argument of type System.String.
- Returns VsphereAsyncRequestStatus.
### Update
Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.

- There is a single argument of type UpdateVcenterInput.
- Returns UpdateVcenterReply.
### Updatehotaddbandwidth
Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.

- There is a single argument of type UpdateVcenterHotAddBandwidthInput.
- Returns RequestSuccess.
### Updatehotaddnetwork
Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.

- There is a single argument of type UpdateVcenterHotAddNetworkInput.
- Returns RequestSuccess.
