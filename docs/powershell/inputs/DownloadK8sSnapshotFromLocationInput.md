### DownloadK8sSnapshotFromLocationInput
Input for downloading a Kubernetes snapshot from a replication/archival target.

- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
- downloadConfig: K8sSnapshotDownloadConfigInput
  - Additional configuration for the operation. This consists of the SLA Domain to be applied to the snapshot after it is downloaded.
- locationId: System.String
  - Required. ID of the archival/replication location.
