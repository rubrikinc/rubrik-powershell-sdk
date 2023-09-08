# Invoke-RscMutateVsphereVm
## Subcommands
### batchexport
Create a mass export for a group of virtual machines.

- There is a single argument of type VsphereVmBatchExportInput.
- Returns BatchAsyncRequestStatus.
### batchexportv3
Create a batch export for a group of virtual machines with datastore cluster support.

- There is a single argument of type VsphereVmBatchExportV3Input.
- Returns BatchAsyncRequestStatus.
### batchinplacerecovery
Supported in v6.0+. Export a snapshot each from a set of virtual machines.

- There is a single argument of type VsphereVmBatchInPlaceRecoveryInput.
- Returns BatchAsyncRequestStatus.
### deletesnapshot
Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.

- There is a single argument of type VsphereVmDeleteSnapshotInput.
- Returns System.String.
### downloadsnapshot
Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.

- There is a single argument of type VsphereVmDownloadSnapshotInput.
- Returns AsyncRequestStatus.
### downloadsnapshotfiles
Download files from snapshot.

- There is a single argument of type VsphereVmDownloadSnapshotFilesInput.
- Returns AsyncRequestStatus.
### excludevmdisks
Exclude or include virtual disks during snapshot.

- There is a single argument of type list of VsphereExcludeVmDisksInputs.
- Returns RequestSuccess.
### exportsnapshotv2
Create a vSphere Export from a snapshot or a point-in-time.

- There is a single argument of type VsphereVmExportSnapshotV2Input.
- Returns AsyncRequestStatus.
### exportsnapshotv3
Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.

- There is a single argument of type VsphereVmExportSnapshotV3Input.
- Returns AsyncRequestStatus.
### exportsnapshotwithdownloadfromcloud
Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.

- There is a single argument of type VsphereVmExportSnapshotWithDownloadFromCloudInput.
- Returns AsyncRequestStatus.
### initiatebatchinstantrecovery
Initiate a mass instant recovery for a group of VMs.

- There is a single argument of type VsphereVmInitiateBatchInstantRecoveryInput.
- Returns BatchAsyncRequestStatus.
### initiatebatchlivemountv2
Initiate a mass live mount for a group of VMs.

- There is a single argument of type VsphereVmInitiateBatchLiveMountV2Input.
- Returns BatchAsyncRequestStatus.
### initiatediskmount
Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.

- There is a single argument of type VsphereVmInitiateDiskMountInput.
- Returns AsyncRequestStatus.
### initiateinplacerecovery
Trigger an in-place recovery from a snapshot or point-in-time.

- There is a single argument of type VsphereVmInitiateInPlaceRecoveryInput.
- Returns AsyncRequestStatus.
### initiateinstantrecoveryv2
Instantly recover a vSphere virtual machine from a snapshot or point-in-time.

- There is a single argument of type VsphereVmInitiateInstantRecoveryV2Input.
- Returns AsyncRequestStatus.
### initiatelivemountv2
Create a vSphere Live Mount from a snapshot or point-in-time.

- There is a single argument of type VsphereVmInitiateLiveMountV2Input.
- Returns AsyncRequestStatus.
### listesxidatastores
List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.

- There is a single argument of type VsphereVmListEsxiDatastoresInput.
- Returns VsphereVmListEsxiDatastoresReply.
### mountrelocate
Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.

- There is a single argument of type VsphereVmMountRelocateInput.
- Returns AsyncRequestStatus.
### mountrelocatev2
Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.

- There is a single argument of type VsphereVmMountRelocateV2Input.
- Returns AsyncRequestStatus.
### poweronofflivemount
Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.

- There is a single argument of type VsphereVmPowerOnOffLiveMountInput.
- Returns VsphereVmPowerOnOffLiveMountReply.
### recoverfiles
Restores multiple files/directories from snapshot.

- There is a single argument of type VsphereVmRecoverFilesInput.
- Returns VsphereAsyncRequestStatus.
### recoverfilesnew
Restores multiple files/directories from snapshot.

- There is a single argument of type VsphereVmRecoverFilesNewInput.
- Returns AsyncRequestStatus.
### registeragent
Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.

- There is a single argument of type VsphereVmRegisterAgentInput.
- Returns RequestSuccess.
### update
Update VM

Supported in v5.0+
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- There is a single argument of type UpdateVsphereVmInput.
- Returns RequestSuccess.
