### AttachmentSpecsForVirtualMachine
Attachment Specifications for Azure Native Virtual Machine.

- managedDiskId: System.String
  - ID of the Azure managed disk attached ot the virtual machine.
- isOsDisk: System.Boolean
  - Specifies if the managed disk is an OS disk.
- lun: System.Int32
  - Logical Unit Number (LUN) associated with a managed disk in a virtual machine.
- isExcludedFromSnapshot: System.Boolean
  - Specifies whether the managed disk is excluded from snapshots.
