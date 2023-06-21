# Invoke-RscMutateNutanix
## Subcommands
### Batchexportvm
Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.

- There is a single argument of type BatchExportNutanixVmInput.
- Returns BatchExportNutanixVmReply.
### Batchmountvm
Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.

- There is a single argument of type BatchMountNutanixVmInput.
- Returns BatchMountNutanixVmReply.
### Bulkondemandsnapshotvm
Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0
Take bulk backups for multiple Nutanix virtual machines.

- There is a single argument of type BulkOnDemandSnapshotNutanixVmInput.
- Returns BulkOnDemandSnapshotNutanixVmReply.
### Createcluster
Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.

- There is a single argument of type CreateNutanixClusterInput.
- Returns AsyncRequestStatus.
### Createondemandbackup
v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.

- There is a single argument of type CreateOnDemandNutanixBackupInput.
- Returns AsyncRequestStatus.
### Createprismcentral
Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.

- There is a single argument of type CreateNutanixPrismCentralInput.
- Returns BatchAsyncRequestStatus.
### Deletecluster
Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.

- There is a single argument of type DeleteNutanixClusterInput.
- Returns AsyncRequestStatus.
### Deletemountv1
Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.

- There is a single argument of type DeleteNutanixMountV1Input.
- Returns AsyncRequestStatus.
### Deleteprismcentral
Remove Nutanix Prism Central

Supported in v9.0
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.

- There is a single argument of type DeleteNutanixPrismCentralInput.
- Returns BatchAsyncRequestStatus.
### Deletesnapshot
v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.

- There is a single argument of type DeleteNutanixSnapshotsInput.
- Returns RequestSuccess.
### Downloadfilessnapshot
v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.

- There is a single argument of type DownloadFilesNutanixSnapshotInput.
- Returns AsyncRequestStatus.
### Downloadsnapshot
Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.

- There is a single argument of type DownloadNutanixSnapshotInput.
- Returns AsyncRequestStatus.
### Downloadvmfromlocation
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.

- There is a single argument of type DownloadNutanixVmFromLocationInput.
- Returns AsyncRequestStatus.
### Exportsnapshot
v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.

- There is a single argument of type ExportNutanixSnapshotInput.
- Returns AsyncRequestStatus.
### Migratemountv1
Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.

- There is a single argument of type MigrateNutanixMountV1Input.
- Returns AsyncRequestStatus.
### Mountsnapshotv1
Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.

- There is a single argument of type MountNutanixSnapshotV1Input.
- Returns AsyncRequestStatus.
### Patchmountv1
Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.

- There is a single argument of type PatchNutanixMountV1Input.
- Returns PatchNutanixMountV1Reply.
### Refreshcluster
Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.

- There is a single argument of type RefreshNutanixClusterInput.
- Returns AsyncRequestStatus.
### Refreshprismcentral
Refresh Nutanix Prism Central metadata

Supported in v9.0
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.

- There is a single argument of type RefreshNutanixPrismCentralInput.
- Returns BatchAsyncRequestStatus.
### Registeragentvm
v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.

- There is a single argument of type RegisterAgentNutanixVmInput.
- Returns RequestSuccess.
### Restorefilessnapshot
Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.

- There is a single argument of type RestoreFilesNutanixSnapshotInput.
- Returns AsyncRequestStatus.
### Updatecluster
Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.

- There is a single argument of type UpdateNutanixClusterInput.
- Returns UpdateNutanixClusterReply.
### Updateprismcentral
Patch Nutanix Prism Central

Supported in v9.0
Patch the host and credentials of Nutanix Prism Central.

- There is a single argument of type UpdateNutanixPrismCentralInput.
- Returns UpdateNutanixPrismCentralReply.
### Updatevm
v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.

- There is a single argument of type UpdateNutanixVmInput.
- Returns System.String.
