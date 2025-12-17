### OlvmVmSubObject
A virtual disk captured in an OLVM virtual machine snapshot.

- diskId: System.String
  - ID of the virtual disk.
- diskAlias: System.String
  - Alias/name of the virtual disk.
- fileSizeInBytes: System.Int64
  - Total size of the disk and associated oVirt snapshots, in bytes.
- provisionedSizeInBytes: System.Int64
  - Provisioned size of the virtual disk in bytes.
- actualSizeInBytes: System.Int64
  - Number of bytes actually used bt the disk.
- storageDomainId: System.String
  - ID of the storage domain containing the virtual disk.
