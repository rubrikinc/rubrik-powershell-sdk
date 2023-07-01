# Invoke-RscMutateHyperv
## Subcommands
### batchexportvm
Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.

- There is a single argument of type BatchExportHypervVmInput.
- Returns BatchExportHypervVmReply.
### batchinstantrecovervm
Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.

- There is a single argument of type BatchInstantRecoverHypervVmInput.
- Returns BatchInstantRecoverHypervVmReply.
### batchmountvm
Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.

- There is a single argument of type BatchMountHypervVmInput.
- Returns BatchMountHypervVmReply.
### batchondemandbackupvm
Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0
Takes on-demand backup of multiple specified Hyper-V virtual machines.

- There is a single argument of type BatchOnDemandBackupHypervVmInput.
- Returns BatchOnDemandBackupHypervVmReply.
### createvirtualmachinesnapshotmount
Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.

- There is a single argument of type CreateHypervVirtualMachineSnapshotMountInput.
- Returns AsyncRequestStatus.
### deleteallsnapshot
Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.

- There is a single argument of type HypervDeleteAllSnapshotsInput.
- Returns RequestSuccess.
### deletevirtualmachinesnapshot
Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.

- There is a single argument of type DeleteHypervVirtualMachineSnapshotInput.
- Returns RequestSuccess.
### deletevirtualmachinesnapshotmount
Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.

- There is a single argument of type DeleteHypervVirtualMachineSnapshotMountInput.
- Returns AsyncRequestStatus.
### downloadsnapshotfromlocation
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.

- There is a single argument of type DownloadHypervSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### downloadvirtualmachinesnapshot
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.

- There is a single argument of type DownloadHypervVirtualMachineSnapshotInput.
- Returns AsyncRequestStatus.
### downloadvirtualmachinesnapshotfile
Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.

- There is a single argument of type DownloadHypervVirtualMachineSnapshotFilesInput.
- Returns AsyncRequestStatus.
### exportvirtualmachine
Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.

- There is a single argument of type ExportHypervVirtualMachineInput.
- Returns AsyncRequestStatus.
### instantrecovervirtualmachinesnapshot
Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.

- There is a single argument of type InstantRecoverHypervVirtualMachineSnapshotInput.
- Returns AsyncRequestStatus.
### ondemandsnapshot
Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.

- There is a single argument of type HypervOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### refreshscvmm
Refresh a given HyperV SCVMM.

- There is a single argument of type RefreshHypervScvmmInput.
- Returns AsyncRequestStatus.
### refreshserver
Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.

- There is a single argument of type RefreshHypervServerInput.
- Returns AsyncRequestStatus.
### registeragentvirtualmachine
Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.

- There is a single argument of type RegisterAgentHypervVirtualMachineInput.
- Returns RequestSuccess.
### registerscvmm
Register HyperV SCVMM to Rubrik Cluster.

- There is a single argument of type RegisterHypervScvmmInput.
- Returns AsyncRequestStatus.
### restorevirtualmachinesnapshotfile
Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.

- There is a single argument of type RestoreHypervVirtualMachineSnapshotFilesInput.
- Returns AsyncRequestStatus.
### scvmmdelete
Delete a given HyperV SCVMM.

- There is a single argument of type HypervScvmmDeleteInput.
- Returns ResponseSuccess.
### scvmmupdate
Update properties for a given HyperV SCVMM.

- There is a single argument of type HypervScvmmUpdateInput.
- Returns HypervScvmmUpdateReply.
### updatevirtualmachine
Update VM

Supported in v5.0+
Update VM with specified properties.

- There is a single argument of type UpdateHypervVirtualMachineInput.
- Returns UpdateHypervVirtualMachineReply.
### updatevirtualmachinesnapshotmount
Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.

- There is a single argument of type UpdateHypervVirtualMachineSnapshotMountInput.
- Returns UpdateHypervVirtualMachineSnapshotMountReply.
