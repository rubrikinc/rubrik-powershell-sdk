### ProxmoxVmSubObject
A virtual disk captured in a Proxmox virtual machine snapshot.

- diskId: System.String
  - Proxmox device key identifying the disk, for example "scsi0" or "virtio0".
- diskAlias: System.String
  - Human-readable alias of the disk.
- storageDomainId: System.String
  - Name of the Proxmox storage holding the disk at backup time.
- fileSizeInBytes: System.Int64
  - Size of the disk file in bytes.
- provisionedSize: System.Int64
  - Provisioned size of the disk in bytes.
- actualSize: System.Int64
  - Actual space consumed by the disk in bytes.
- diskFormat: System.String
  - Disk format, for example "qcow2" or "raw".
- diskInterface: System.String
  - Bus/interface of the disk, for example "scsi" or "virtio".
- isBootable: System.Boolean
  - Whether the disk is marked bootable.
