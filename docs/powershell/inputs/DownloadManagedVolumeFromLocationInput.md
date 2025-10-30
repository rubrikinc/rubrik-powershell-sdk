### DownloadManagedVolumeFromLocationInput
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location can be a replication target or an archival location.

- downloadConfig: DownloadManagedVolumeRequestInput
  - Additional configuration for the operation. This includes the SLA Domain to be assigned to the snapshot when it is downloaded.
- locationId: System.String
  - Required. v7.0-v8.1: ID of the replication location.
      v9.0+: ID of the remote location.
- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
- userNote: System.String
  - Required. User note to associate with audits.
