### NutanixVmMountSummary
Supported in v6.0+

- id: System.String
  - Required. Supported in v6.0+
  ID of the Live Mount.
- isReady: System.Boolean
  - Required. Supported in v6.0+
  Specifies whether the Live Mount is ready.
- mountRequestId: System.String
  - Supported in v6.0+
  ID of the request which initiated the Live Mount.
- mountedDate: DateTime
  - Supported in v6.0+
  Timestamp at which the Live Mount was created.
- mountedVmId: System.String
  - Supported in v6.0+
  ID of the mounted virtual machine.
- mountedVmIpAddress: System.String
  - Supported in v6.0+
  IP address of the mounted virtual machine.
- mountedVmName: System.String
  - Supported in v6.0+
  Name of the mounted virtual machine.
- powerStatus: System.String
  - Supported in v6.0+
  The power status of the mounted virtual machine.
- snapshotDate: DateTime
  - Required. Supported in v6.0+
  Timestamp of the Nutanix virtual machine snapshot on which the Live Mount is based.
- storageContainerName: System.String
  - Supported in v6.0+
  ID of the Nutanix storage container which contains the mounted virtual disks.
- targetNutanixClusterId: System.String
  - Required. Supported in v6.0+
  ID of the Nutanix cluster to which the mounted virtual machine belongs.
- targetNutanixClusterName: System.String
  - Supported in v6.0+
  Name of the Nutanix cluster to which the mounted virtual machine belongs.
- unmountRequestId: System.String
  - Supported in v6.0+
  ID of the request to delete the Live Mount.
- vmId: System.String
  - Required. Supported in v6.0+
  ID of the source virtual machine of the Live Mount.
- vmName: System.String
  - Supported in v6.0+
  Name of the source virtual machine of the Live Mount.
- migrationStatus: System.String
  - Supported in v7.0+
  The status of the migration job for the mounted virtual machine. Valid values are 'REQUESTED', 'RUNNING', 'SUCCEEDED', and 'FAILED'. An unspecified value indicates that no migration job has been initiated for the mounted virtual machine.
