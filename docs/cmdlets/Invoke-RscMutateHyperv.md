# Invoke-RscMutateHyperv
## Subcommands
### DeleteAllSnapshot
Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.

- The Input parameter takes a single value of type HypervDeleteAllSnapshotsInput.
- Returns RequestSuccess.
### OnDemandSnapshot
Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.

- The Input parameter takes a single value of type HypervOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### ScvmmDelete
Delete a given HyperV SCVMM.

- The Input parameter takes a single value of type HypervScvmmDeleteInput.
- Returns ResponseSuccess.
### ScvmmUpdate
Update properties for a given HyperV SCVMM.

- The Input parameter takes a single value of type HypervScvmmUpdateInput.
- Returns HypervScvmmUpdateReply.
### batchExportVm
Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.

- The Input parameter takes a single value of type BatchExportHypervVmInput.
- Returns BatchExportHypervVmReply.
### batchInstantRecoverVm
Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.

- The Input parameter takes a single value of type BatchInstantRecoverHypervVmInput.
- Returns BatchInstantRecoverHypervVmReply.
### batchMountVm
Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.

- The Input parameter takes a single value of type BatchMountHypervVmInput.
- Returns BatchMountHypervVmReply.
### batchOnDemandBackupVm
Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0
Takes on-demand backup of multiple specified Hyper-V virtual machines.

- The Input parameter takes a single value of type BatchOnDemandBackupHypervVmInput.
- Returns BatchOnDemandBackupHypervVmReply.
### createVirtualMachineSnapshotMount
Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.

- The Input parameter takes a single value of type CreateHypervVirtualMachineSnapshotMountInput.
- Returns AsyncRequestStatus.
### deleteVirtualMachineSnapshot
Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.

- The Input parameter takes a single value of type DeleteHypervVirtualMachineSnapshotInput.
- Returns RequestSuccess.
### deleteVirtualMachineSnapshotMount
Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.

- The Input parameter takes a single value of type DeleteHypervVirtualMachineSnapshotMountInput.
- Returns AsyncRequestStatus.
### downloadSnapshotFromLocation
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.

- The Input parameter takes a single value of type DownloadHypervSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### downloadVirtualMachineSnapshot
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.

- The Input parameter takes a single value of type DownloadHypervVirtualMachineSnapshotInput.
- Returns AsyncRequestStatus.
### downloadVirtualMachineSnapshotFile
Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.

- The Input parameter takes a single value of type DownloadHypervVirtualMachineSnapshotFilesInput.
- Returns AsyncRequestStatus.
### exportVirtualMachine
Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.

- The Input parameter takes a single value of type ExportHypervVirtualMachineInput.
- Returns AsyncRequestStatus.
### instantRecoverVirtualMachineSnapshot
Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.

- The Input parameter takes a single value of type InstantRecoverHypervVirtualMachineSnapshotInput.
- Returns AsyncRequestStatus.
### refreshScvmm
Refresh a given HyperV SCVMM.

- The Input parameter takes a single value of type RefreshHypervScvmmInput.
- Returns AsyncRequestStatus.
### refreshServer
Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.

- The Input parameter takes a single value of type RefreshHypervServerInput.
- Returns AsyncRequestStatus.
### registerAgentVirtualMachine
Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.

- The Input parameter takes a single value of type RegisterAgentHypervVirtualMachineInput.
- Returns RequestSuccess.
### registerScvmm
Register HyperV SCVMM to Rubrik Cluster.

- The Input parameter takes a single value of type RegisterHypervScvmmInput.
- Returns AsyncRequestStatus.
### restoreVirtualMachineSnapshotFile
Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.

- The Input parameter takes a single value of type RestoreHypervVirtualMachineSnapshotFilesInput.
- Returns AsyncRequestStatus.
### updateVirtualMachine
Update VM

Supported in v5.0+
Update VM with specified properties.

- The Input parameter takes a single value of type UpdateHypervVirtualMachineInput.
- Returns UpdateHypervVirtualMachineReply.
### updateVirtualMachineSnapshotMount
Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.

- The Input parameter takes a single value of type UpdateHypervVirtualMachineSnapshotMountInput.
- Returns UpdateHypervVirtualMachineSnapshotMountReply.
