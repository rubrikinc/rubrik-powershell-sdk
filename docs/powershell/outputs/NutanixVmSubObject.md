### NutanixVmSubObject
A virtual disk captured in a Nutanix virtual machine snapshot.

- clusterUuid: System.String
- diskId: System.String
  - ID of the virtual disk.
- snapshotContainer: System.String
  - Nutanix container holding the snapshot.
- relSnapshotDiskFilePath: System.String
  - Relative path to the snapshot disk file.
- logicalSnapshotFileSizeInBytes: System.Int64
  - Logical file size of the virtual disk in bytes.
- diskUsedBytesOpt: System.Int64
  - Actual disk usage in bytes (optional).
