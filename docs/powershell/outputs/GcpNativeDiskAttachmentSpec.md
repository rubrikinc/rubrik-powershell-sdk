### GcpNativeDiskAttachmentSpec
GCP native disk attachment specifications.

- diskId: System.String
  - Unique identifier of the disk.
- devicePath: System.String
  - Device name where the disk is attached on the instance.
- isBootDisk: System.Boolean
  - Specifies whether the disk is a boot disk.
- isExcludedFromSnapshot: System.Boolean
  - Specifies whether the disk is excluded from snapshots.
- gceInstanceId: System.String
  - Unique identifier of the GCE instance.
- diskIndex: System.Int32
  - Index indicating the order of disk attachment on the instance.
