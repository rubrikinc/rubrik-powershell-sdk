### HypervVirtualMachineMountSummary
Supported in v5.0+

- hostId: System.String
  - Supported in v5.0+
- hostName: System.String
  - Supported in v5.0+
- id: System.String
  - Required. Supported in v5.0+
- isReady: System.Boolean
  - Required. Supported in v5.0+
- mountRequestId: System.String
  - Supported in v5.0+
- mountedVmId: System.String
  - Supported in v5.0+
- mountedVmName: System.String
  - Supported in v5.0+
- snapshotDate: DateTime
  - Required. Supported in v5.0+
- unmountRequestId: System.String
  - Supported in v5.0+
- vmId: System.String
  - Required. Supported in v5.0+
- vmName: System.String
  - Required. Supported in v5.0+
- targetVmName: System.String
  - Supported in v9.1+
  The name of the target virtual machine.
- attachedDiskCount: System.Int32
  - Supported in v9.1+
  The number of disks attached to the target virtual machine, if the mount is a disk-level mount.
- isDiskLevelMount: System.Boolean
  - Supported in v9.1+
  A boolean field that indicates whether the mount is a disk-level mount.
- mountTime: DateTime
  - This field indicates the time of mounting.
- powerStatus: HypervVirtualMachineMountSummaryPowerStatus
  - 
