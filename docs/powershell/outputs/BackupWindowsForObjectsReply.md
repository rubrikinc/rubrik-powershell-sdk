### BackupWindowsForObjectsReply
Result of backupWindowsForObjects.

- entries: list of ObjectBackupWindowsEntrys
  - Per-object backup window entries, one per requested id. Ordered by the
request's `sort_by`, or positionally in request order when it is unset.
