### SetObjectBackupWindowsInput
Input for setting an object-level backup window override on a batch
of managed objects. The same backup window group is applied to every
managed object in the list.

- objectIds: list of System.Strings
  - Identifiers of the managed objects to apply the override to. Every
object in this list receives the same `backupWindowGroup`.
- backupWindowGroup: BackupWindowSpecInput
  - Backup window group to apply to the listed managed objects as an
object-level override of the SLA-level backup window. When unset,
any existing object-level override on the listed objects is cleared.
