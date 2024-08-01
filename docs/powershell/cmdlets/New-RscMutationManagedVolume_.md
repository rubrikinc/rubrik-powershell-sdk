# New-RscMutationManagedVolume
## Subcommands
### add
Create a Managed Volume

Supported in v7.0+
v7.0: Initiates an asynchronous job to create a Managed Volume stack.
v8.0+: Start an asynchronous job to create a Managed Volume stack.

- There is a single argument of type AddManagedVolumeInput.
- Returns AddManagedVolumeReply.
### beginsnapshot
Begin Managed Volume snapshot

Supported in v7.0+
Opens the Managed Volume for writes. All data written to the Managed Volume until the next end-snapshot call will be part of this snapshot.

- There is a single argument of type BeginManagedVolumeSnapshotInput.
- Returns BeginManagedVolumeSnapshotReply.
### delete
Delete a Managed Volume

Supported in v7.0+
Delete a Managed Volume.

- There is a single argument of type DeleteManagedVolumeInput.
- Returns DeleteManagedVolumeReply.
### deletesnapshotexport
Delete an exported Managed Volume snapshot

Supported in v7.0+
Deletes an exported Managed Volume snapshot, identified by the snapshot ID.

- There is a single argument of type DeleteManagedVolumeSnapshotExportInput.
- Returns AsyncRequestStatus.
### downloadfiles
Download files from a managed volume backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified managed volume backup. The response returns an asynchronous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'managed-volume/request/{id}'.

- There is a single argument of type DownloadManagedVolumeFilesInput.
- Returns AsyncRequestStatus.
### downloadfromlocation
Download a snapshot from a remote target

Supported in v7.0+
Initiates a job to download a snapshot from the specified
location when the snapshot does not exist locally.
The specified location has to be a remote target connected to this Rubrik cluster.

- There is a single argument of type DownloadManagedVolumeFromLocationInput.
- Returns AsyncRequestStatus.
### endsnapshot
End Managed Volume snapshot

Supported in v7.0+
Close a Managed Volume for writes. A snapshot will be created containing all writes since the last begin-snapshot call.

- There is a single argument of type EndManagedVolumeSnapshotInput.
- Returns EndManagedVolumeSnapshotReply.
### exportsnapshot
Create a request to export a snapshot

Supported in v5.0+
Export a managed volume snapshot as a share.

- There is a single argument of type ExportManagedVolumeSnapshotInput.
- Returns AsyncRequestStatus.
### resize
Resize managed volume

Supported in v5.3+
Resize the managed volume to a larger size. Once a volume size has been increased, it can not be decreased.

- There is a single argument of type ResizeManagedVolumeInput.
- Returns AsyncRequestStatus.
### takeondemandsnapshot
Take an on-demand snapshot of an SLA Managed Volume

Supported in v5.3+
Create a job for an on-demand snapshot of an SLA Managed Volume. The response returns a request ID. To see the status of the request, poll 'managed-volume/request/{id}' with the request ID obtained in the response.

- There is a single argument of type TakeManagedVolumeOnDemandSnapshotInput.
- Returns AsyncRequestStatus.
### update
Mutation to update an existing Managed Volume.

- There is a single argument of type UpdateManagedVolumeInput.
- Returns UpdateManagedVolumeReply.
