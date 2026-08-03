### ObjectBackupWindowStatus
Represents the object-level backup window status of a hierarchy object.

- isObjectBackupWindowConfigured: System.Boolean
  - Whether an object-level backup window override is configured directly on
this object. True when the effective backup window is supplied by the
object-level override (scope OBJECT_LEVEL); false when the object inherits
its SLA Domain's window (scope SLA_LEVEL).
- scope: BackupWindowScope
  - The backup window layer that supplied the effective window: OBJECT_LEVEL
when the object has its own override, SLA_LEVEL when it inherits from its
SLA Domain.
- backupWindowGroup: BackupWindowSpec
  - The effective backup window group applied to the object. Unset when the
object has no object-level override and its SLA Domain defines no window.
- pendingBackupWindowStatus: PendingBackupWindowAssignmentStatus
  - Pending dispatch state for the object's most recent object-level backup
window assignment.
