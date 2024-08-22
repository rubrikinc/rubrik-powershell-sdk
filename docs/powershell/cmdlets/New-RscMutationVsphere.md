# New-RscMutationVsphere
## Subcommands
### bulkondemandsnapshot
Trigger a bulk on demand snapshot.

- There is a single argument of type VsphereBulkOnDemandSnapshotInput.
- Returns BatchAsyncRequestStatus.
### createadvancedtag
Create a multi-tag filter for vSphere tags

Supported in v7.0+
v7.0-v9.1: Create a filter consisting of vSphere tags joined with logical operators.
v9.2+: Create a filter consisting of vSphere tags joined with logical operators. It is not supported onStandalone Hosts.

- There is a single argument of type CreateVsphereAdvancedTagInput.
- Returns CreateVsphereAdvancedTagReply.
### deleteadvancedtag
Remove the multi-tag filter

Supported in v7.0+
v7.0-v9.1: Remove the multi-tag filter.
v9.2+: Remove the multi-tag filter. It is not supported on Standalone Hosts.

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
### exportsnapshottostandalonehostv2
Export snapshot of a virtual machine to standalone ESXi server.

- There is a single argument of type VsphereExportSnapshotToStandaloneHostV2Input.
- Returns AsyncRequestStatus.
### ondemandsnapshot
- There is a single argument of type VsphereOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### snapshotdownloadfilesfromlocation
Initiate a job to download multiple files or folders

Supported in v8.0+
Initiates a job to download one or more files or folders from an archived virtual machine snapshot. Returns the job instance ID.

- There is a single argument of type VsphereSnapshotDownloadFilesFromLocationInput.
- Returns AsyncRequestStatus.
### snapshotrestorefilesfromlocation
Initiate a job to restore multiple files or folders

Supported in v8.0+
Initiates a job to restore one or more files or folders from an archived virtual machine snapshot. Returns the job instance ID.

- There is a single argument of type VsphereSnapshotRestoreFilesFromLocationInput.
- Returns AsyncRequestStatus.
### updateadvancedtag
Update the multi-tag filter

Supported in v7.0+
v7.0-v9.1: Updates the name, condition, and description of the specified multi-tag filter.
v9.2+: Updates the name, condition, and description of the specified multi-tag filter. It is not supported on Standalone Hosts.

- There is a single argument of type UpdateVsphereAdvancedTagInput.
- Returns UpdateVsphereAdvancedTagReply.
### updatevmnew
Supported in v9.2+. Update a virtual machine withspecified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- There is a single argument of type UpdateVsphereVmNewInput.
- Returns RequestSuccess.
