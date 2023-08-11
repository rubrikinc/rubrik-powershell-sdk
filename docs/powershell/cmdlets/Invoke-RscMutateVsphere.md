# Invoke-RscMutateVsphere
## Subcommands
### bulkondemandsnapshot
Trigger a bulk on demand snapshot.

- There is a single argument of type VsphereBulkOnDemandSnapshotInput.
- Returns BatchAsyncRequestStatus.
### createadvancedtag
Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.

- There is a single argument of type CreateVsphereAdvancedTagInput.
- Returns CreateVsphereAdvancedTagReply.
### deleteadvancedtag
Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.

- There is a single argument of type DeleteVsphereAdvancedTagInput.
- Returns RequestSuccess.
### deletelivemount
Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.

- There is a single argument of type DeleteVsphereLiveMountInput.
- Returns AsyncRequestStatus.
### downloadvirtualmachinefiles
Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.

- There is a single argument of type DownloadVsphereVirtualMachineFilesInput.
- Returns AsyncRequestStatus.
### exportsnapshottostandalonehost
- There are 10 arguments.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - vmName - System.String
    - disableNetwork - System.Boolean
    - removeNetworkDevices - System.Boolean
    - powerOn - System.Boolean
    - keepMacAddresses - System.Boolean
    - hostIpAddress - System.String
    - datastoreName - System.String
    - hostUsername - System.String
    - hostPassword - System.String
- Returns VsphereAsyncRequestStatus.
### exportsnapshottostandalonehostv2
Export snapshot of a virtual machine to standalone ESXi server.

- There is a single argument of type VsphereExportSnapshotToStandaloneHostV2Input.
- Returns AsyncRequestStatus.
### ondemandsnapshot
- There is a single argument of type VsphereOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### updateadvancedtag
Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.

- There is a single argument of type UpdateVsphereAdvancedTagInput.
- Returns UpdateVsphereAdvancedTagReply.
