### DownloadHypervSnapshotFromLocationInput
Input location to download the Hyper-V snapshot from.

- downloadConfig: HypervVirtualMachineSnapshotDownloadConfigInput
  - Additional configuration for the operation. This consists of the SLA Domain to be applied to the snapshot after it is downloaded.
- locationId: System.String
  - Required. ID of the replication location.
- snapshotId: System.String
  - Required. ID of the snapshot to be downloaded.
