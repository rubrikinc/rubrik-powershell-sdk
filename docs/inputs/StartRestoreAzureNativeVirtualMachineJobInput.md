### StartRestoreAzureNativeVirtualMachineJobInput
Inputs to trigger the job to restore Azure Native Virtual Machine.

- recoveryDiskIds: a list of System.Strings
  - Specifies a list of Azure disk unique native IDs that will be restored. When empty, all disks from the snapshot will be restored.
- shouldPowerOn: System.Boolean
  - Specifies whether the restored virtual machine is to be launched in powered on state. When false, the restored virtual machine will not be connected to the internet.
- shouldRestoreTags: System.Boolean
  - Specifies whether the tags at the time of snapshot should also be restored. When true, the tags on the virtual machine will be reverted to the time of the backup.
- snapshotId: System.String
  - Snapshot ID of the snapshot which is to be restored.
- snapshotTypeToUseIfSourceExpired: SnapshotTypeForRestoreIfSourceExpired
  - Snapshot type to use if source snapshot is expired.
