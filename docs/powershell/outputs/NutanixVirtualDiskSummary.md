### NutanixVirtualDiskSummary
Supported in v5.2+

- deviceType: System.String
  - Supported in v5.2+
  Type of virtual disk.
- sizeInBytes: System.Int64
  - Supported in v5.2+
  Size of the virtual disk in bytes.
- uuid: System.String
  - Supported in v5.2-v5.3
  UUID of the disk
- isSnapshottable: System.Boolean
  - Supported in v6.0+
  Specifies whether the Nutanix device can create a snapshot of the disk. Value is true when a snapshot can be created.
- label: System.String
  - Supported in v6.0+
  Label of the disk assigned by Nutanix.
- vmDiskUuid: System.String
  - Supported in v6.0+
  UUID of the virtual machine disk.
