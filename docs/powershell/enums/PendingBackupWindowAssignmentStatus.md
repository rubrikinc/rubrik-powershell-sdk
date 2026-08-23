### PendingBackupWindowAssignmentStatus
The status of a backup window assignment. Reflects an in-flight
object-level backup-window assignment sync to CDM only. An explicit
SLA_LEVEL read is returned without a pending signal (matching GetSLA, which
returns the SLA's window directly regardless of its CDM sync state).

- NO_PENDING_BACKUP_WINDOW_ASSIGNMENT - No backup window assignment is pending.
- PENDING_ASSIGNMENT - An object-level assignment (set, edit, or clear) has not yet synced to CDM.
