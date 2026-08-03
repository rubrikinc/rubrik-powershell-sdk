### RestoreO365SnappableInput
Request for restoring an O365 snappable (OneDrive, SharePoint, Exchange,
Calendar, Contacts, Teams).

- snappableType: SnappableType
  - Type of the workload to restore, as selected by the caller. CALENDAR
and CONTACTS are remapped to EXCHANGE before the restore job is
scheduled.
- sourceSnappableUuid: System.String
  - UUID of the source workload.
- destinationSnappableUuid: System.String
  - UUID of the target workload.
- actionType: O365RestoreActionType
  - Type of restore action to perform (restore, export, in-place restore,
failed-items export, self-service restore, anomaly-forensics download).
- restoreConfig: SnappableRestoreConfig
  - Configuration for restore job.
