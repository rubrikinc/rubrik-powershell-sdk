# Invoke-RscMutateVsphereVm
## Subcommands
### BatchExport
Create a mass export for a group of virtual machines.

- The Input parameter takes a single value of type VsphereVmBatchExportInput.
- Returns BatchAsyncRequestStatus.
### BatchInPlaceRecovery
Supported in v6.0+. Export a snapshot each from a set of virtual machines.

- The Input parameter takes a single value of type VsphereVmBatchInPlaceRecoveryInput.
- Returns BatchAsyncRequestStatus.
### BatchLiveMount
- The Input parameter takes a hashtable with 2 name and value pairs.
    - clusterUuid - System.String
    - config - BatchMountSnapshotJobConfigInput: Configuration object containing an array of virtual machine IDs, a way to indicate the snapshot to be chosen and mount configs.
- Returns BatchAsyncRequestStatus.
### DeleteLiveMount
- The Input parameter takes a hashtable with 2 name and value pairs.
    - force - System.Boolean
    - livemountId - System.String
- Returns VsphereAsyncRequestStatus.
### DeleteSnapshot
Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.

- The Input parameter takes a single value of type VsphereVmDeleteSnapshotInput.
- Returns System.String.
### DownloadSnapshot
Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.

- The Input parameter takes a single value of type VsphereVmDownloadSnapshotInput.
- Returns AsyncRequestStatus.
### DownloadSnapshotFile
Download files from snapshot.

- The Input parameter takes a single value of type VsphereVmDownloadSnapshotFilesInput.
- Returns AsyncRequestStatus.
### ExcludeVmDisk
Exclude or include virtual disks during snapshot.

- The Input parameter takes a single value of type a list of VsphereExcludeVmDisksInputs.
- Returns RequestSuccess.
### ExportSnapshot
- The Input parameter takes a hashtable with 10 name and value pairs.
    - datastoreId - System.String
    - disableNetwork - System.Boolean
    - hostID - System.String
    - keepMacAddresses - System.Boolean
    - powerOn - System.Boolean
    - removeNetworkDevices - System.Boolean
    - shouldRecoverTags - System.Boolean
    - snapshotFid - System.String: Snapshot forever UUID in Rubrik Security Cloud.
    - unregsiterVm - System.Boolean
    - vmName - System.String
- Returns VsphereAsyncRequestStatus.
### ExportSnapshotV2
Create a vSphere Export from a snapshot or a point-in-time.

- The Input parameter takes a single value of type VsphereVmExportSnapshotV2Input.
- Returns AsyncRequestStatus.
### ExportSnapshotV3
Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.

- The Input parameter takes a single value of type VsphereVmExportSnapshotV3Input.
- Returns AsyncRequestStatus.
### ExportSnapshotWithDownloadFromCloud
Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.

- The Input parameter takes a single value of type VsphereVmExportSnapshotWithDownloadFromCloudInput.
- Returns AsyncRequestStatus.
### InitiateBatchInstantRecovery
Initiate a mass instant recovery for a group of VMs.

- The Input parameter takes a single value of type VsphereVmInitiateBatchInstantRecoveryInput.
- Returns BatchAsyncRequestStatus.
### InitiateBatchLiveMountV2
Initiate a mass live mount for a group of VMs.

- The Input parameter takes a single value of type VsphereVmInitiateBatchLiveMountV2Input.
- Returns BatchAsyncRequestStatus.
### InitiateDiskMount
Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.

- The Input parameter takes a single value of type VsphereVmInitiateDiskMountInput.
- Returns AsyncRequestStatus.
### InitiateInPlaceRecovery
Trigger an in-place recovery from a snapshot or point-in-time.

- The Input parameter takes a single value of type VsphereVmInitiateInPlaceRecoveryInput.
- Returns AsyncRequestStatus.
### InitiateInstantRecovery
- The Input parameter takes a hashtable with 10 name and value pairs.
    - disableNetwork - System.Boolean
    - hostID - System.String
    - keepMacAddresses - System.Boolean
    - powerOn - System.Boolean
    - preserveMOID - System.Boolean
    - removeNetworkDevices - System.Boolean
    - shouldRecoverTags - System.Boolean
    - snapshotFid - System.String: Snapshot forever UUID in Rubrik Security Cloud.
    - vlan - System.Int32
    - vmName - System.String
- Returns VsphereAsyncRequestStatus.
### InitiateInstantRecoveryV2
Instantly recover a vSphere virtual machine from a snapshot or point-in-time.

- The Input parameter takes a single value of type VsphereVmInitiateInstantRecoveryV2Input.
- Returns AsyncRequestStatus.
### InitiateLiveMount
- The Input parameter takes a hashtable with 11 name and value pairs.
    - createDatastoreOnly - System.Boolean
    - datastoreName - System.String
    - disableNetwork - System.Boolean
    - hostID - System.String
    - keepMacAddresses - System.Boolean
    - powerOn - System.Boolean
    - removeNetworkDevices - System.Boolean
    - shouldRecoverTags - System.Boolean
    - snapshotFid - System.String: Snapshot forever UUID in Rubrik Security Cloud.
    - vlan - System.Int32
    - vmName - System.String
- Returns VsphereAsyncRequestStatus.
### InitiateLiveMountV2
Create a vSphere Live Mount from a snapshot or point-in-time.

- The Input parameter takes a single value of type VsphereVmInitiateLiveMountV2Input.
- Returns AsyncRequestStatus.
### ListEsXiDatastore
Retrieve a list of the datastores for a specified ESXi host

- The Input parameter takes a hashtable with 4 name and value pairs.
    - clusterUuid - System.String
    - ipAddress - System.String
    - password - System.String
    - username - System.String
- Returns DatastoresListResponse.
### ListEsxiDatastore
List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.

- The Input parameter takes a single value of type VsphereVmListEsxiDatastoresInput.
- Returns VsphereVmListEsxiDatastoresReply.
### MountRelocate
Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.

- The Input parameter takes a single value of type VsphereVmMountRelocateInput.
- Returns AsyncRequestStatus.
### MountRelocateV2
Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.

- The Input parameter takes a single value of type VsphereVmMountRelocateV2Input.
- Returns AsyncRequestStatus.
### PowerOnOffLiveMount
Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.

- The Input parameter takes a single value of type VsphereVmPowerOnOffLiveMountInput.
- Returns VsphereVmPowerOnOffLiveMountReply.
### RecoverFile
Restores multiple files/directories from snapshot.

- The Input parameter takes a single value of type VsphereVmRecoverFilesInput.
- Returns VsphereAsyncRequestStatus.
### RecoverFilesNew
Restores multiple files/directories from snapshot.

- The Input parameter takes a single value of type VsphereVmRecoverFilesNewInput.
- Returns AsyncRequestStatus.
### RegisterAgent
Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.

- The Input parameter takes a single value of type VsphereVmRegisterAgentInput.
- Returns RequestSuccess.
### Update
Update VM

Supported in v5.0+
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.

- The Input parameter takes a single value of type UpdateVsphereVmInput.
- Returns RequestSuccess.
