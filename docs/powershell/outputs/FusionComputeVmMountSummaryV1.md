### FusionComputeVmMountSummaryV1
Summary information for a FusionCompute Live Mount.

- id: System.String
  - Required. Supported in v9.6+
ID of the Live Mount.
- mountRequestId: System.String
  - Supported in v9.6+
ID of the mount job request.
- datastoreName: System.String
  - Supported in v9.6+
The name of the NFS datastore that contains the mounted virtual machine disks.
- mountTimestamp: DateTime
  - Supported in v9.6+
Timestamp at which the mount was created.
- mountedVmId: System.String
  - Supported in v9.6+
ID of the mounted virtual machine on FusionCompute.
- vmId: System.String
  - Required. Supported in v9.6+
ID of the original virtual machine.
- snapshotDate: DateTime
  - Supported in v9.6+
Date of the source snapshot.
- isReady: System.Boolean
  - Required. Supported in v9.6+
Whether the Live Mount is ready.
- unmountRequestId: System.String
  - Supported in v9.6+
ID of the unmount job request.
- hostId: System.String
  - Supported in v9.6+
ID of the FusionCompute host.
