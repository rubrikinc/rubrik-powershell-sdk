### BackupWindowSpec
Group of backup windows allowing backup termination.
This groups regular backup windows and first full backup windows together
with a shared setting that controls whether backups should be automatically
terminated when they run longer than their allocated backup window.

- backupWindows: list of BackupWindows
  - List of all backup windows (regular and first full).
Each BackupWindow has a backupWindowType field that specifies whether
it's a regular backup window (BACKUP_WINDOW_TYPE_REGULAR) or a first full
backup window (BACKUP_WINDOW_TYPE_FIRST_FULL).
- terminateBackupsExceedingBackupWindow: System.Boolean
  - Terminates backup jobs that exceed the configured backup window
boundaries.
