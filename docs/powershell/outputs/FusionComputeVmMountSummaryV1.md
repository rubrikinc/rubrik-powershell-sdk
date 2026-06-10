### FusionComputeVmMountSummaryV1
Summary information for a FusionCompute Live Mount.

- id: System.String
  - Required. ID of the Live Mount.
- mountRequestId: System.String
  - ID of the mount job request.
- datastoreName: System.String
  - The name of the NFS datastore that contains the mounted virtual machine disks.
- mountTimestamp: DateTime
  - Timestamp at which the mount was created.
- mountedVmId: System.String
  - ID of the mounted virtual machine on FusionCompute.
- vmId: System.String
  - Required. ID of the original virtual machine.
- snapshotDate: DateTime
  - Date of the source snapshot.
- isReady: System.Boolean
  - Required. Whether the Live Mount is ready.
- unmountRequestId: System.String
  - ID of the unmount job request.
- hostId: System.String
  - ID of the FusionCompute host.
