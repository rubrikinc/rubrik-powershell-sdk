### DownloadSapHanaSnapshotFromLocationInput
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location can be replication target or archival location. If SLA Domain is not selected, the snapshot will be retained forever.

- downloadConfig: SapHanaDownloadRequestInput
  - Additional configuration for the download operation. This includes the SLA Domain assigned to the downloaded snapshot.
- locationId: System.String
  - Required. ID of the remote location.
- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
