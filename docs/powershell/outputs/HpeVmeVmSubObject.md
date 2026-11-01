### HpeVmeVmSubObject
A virtual disk captured in an HPE Virtual Machine Essentials virtual
machine snapshot.

- diskId: System.String
  - ID of the snapshot disk.
- fileSizeInBytes: System.Int64
  - Size of the disk in bytes.
- volumeName: System.String
  - The manager's name for the volume, for example "root".
- isRootVolume: System.Boolean
  - Whether the disk is the bootable root volume.
- displayOrder: System.Int32
  - Position of the disk in the virtual machine's volume list.
- diskFormat: System.String
  - Disk format, for example "qcow2" or "raw".
- diskBus: System.String
  - Bus of the disk, for example "virtio".
- diskTarget: System.String
  - Target device of the disk in libvirt, for example "vda".
- storageType: System.String
  - Numeric ID of the volume type.
- datastoreId: System.String
  - The manager's numeric ID of the datastore that held the volume at
backup time.
