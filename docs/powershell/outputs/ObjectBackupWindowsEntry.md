### ObjectBackupWindowsEntry
Backup window information for a single managed object.

- objectId: System.String
  - The managed object's identifier.
- backupWindowGroup: BackupWindowSpec
  - Backup window group applied to the managed object at the layer
indicated by `scope` below. Unset when the object has no SLA-level
window and no object-level override.
- scope: BackupWindowScope
  - The layer that supplied `backupWindowGroup`:
* OBJECT_LEVEL: the object has an object-level override.
* SLA_LEVEL: the object has no override and inherits from its SLA.
Always OBJECT_LEVEL or SLA_LEVEL, never null/unspecified. An unset
`backupWindowGroup` with scope SLA_LEVEL means the governing SLA defines
no window.
- pendingBackupWindowStatus: PendingBackupWindowAssignmentStatus
  - Pending dispatch state for the object's most recent object-level
backup-window assignment. Only ever PENDING_ASSIGNMENT when `scope`
resolved to OBJECT_LEVEL; always NO_PENDING for SLA_LEVEL reads.
