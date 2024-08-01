### MountDiskJobConfigInput
Supported in v5.0+

- targetVmId: System.String
  - Supported in v5.0+
      ID of the target virtual machine where the disks will be attached to. The default value will be the virtual machine of the snapshot.
- vlan: System.Int32
  - Supported in v5.0+
      The VLAN used by the ESXi host to mount the datastore.
- vmdkIds: list of System.Strings
  - Supported in v5.0+
      The VMDK files to attach to the existing virtual machine. By default, this value is empty, which attaches all of the VMDKs in the snapshot to the target virtual machine.
- unmountTimeOpt: System.Int64
  - Specifies an optional future unmount time for the current live mount.
