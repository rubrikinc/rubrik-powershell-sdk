# Invoke-RscMutateVsphere
## Subcommands
### BulkOnDemandSnapshot
Trigger a bulk on demand snapshot.

- The Input parameter takes a single value of type VsphereBulkOnDemandSnapshotInput.
- Returns BatchAsyncRequestStatus.
### ExportSnapshotToStandaloneHost
- The Input parameter takes a hashtable with 10 name and value pairs.
    - datastoreName - System.String
    - disableNetwork - System.Boolean
    - hostIpAddress - System.String
    - hostPassword - System.String
    - hostUsername - System.String
    - keepMacAddresses - System.Boolean
    - powerOn - System.Boolean
    - removeNetworkDevices - System.Boolean
    - snapshotFid - System.String: Snapshot forever UUID in Rubrik Security Cloud.
    - vmName - System.String
- Returns VsphereAsyncRequestStatus.
### ExportSnapshotToStandaloneHostV2
Export snapshot of a virtual machine to standalone ESXi server.

- The Input parameter takes a single value of type VsphereExportSnapshotToStandaloneHostV2Input.
- Returns AsyncRequestStatus.
### OnDemandSnapshot
- The Input parameter takes a single value of type VsphereOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### createAdvancedTag
Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.

- The Input parameter takes a single value of type CreateVsphereAdvancedTagInput.
- Returns CreateVsphereAdvancedTagReply.
### deleteAdvancedTag
Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.

- The Input parameter takes a single value of type DeleteVsphereAdvancedTagInput.
- Returns RequestSuccess.
### deleteLiveMount
Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.

- The Input parameter takes a single value of type DeleteVsphereLiveMountInput.
- Returns AsyncRequestStatus.
### downloadVirtualMachineFile
Download Virtual Machine files from a snapshot

Supported in v9.0
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.

- The Input parameter takes a single value of type DownloadVsphereVirtualMachineFilesInput.
- Returns AsyncRequestStatus.
### updateAdvancedTag
Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.

- The Input parameter takes a single value of type UpdateVsphereAdvancedTagInput.
- Returns UpdateVsphereAdvancedTagReply.
