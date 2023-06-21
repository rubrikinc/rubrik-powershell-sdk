### SapHanaLogBackup
Backup associated with the SAP HANA log backup.

- endTime: DateTime
  - End time for log backup.
- bytesTransferred: System.Int64
  - Total bytes transferred for log backup.
- backupId: System.Int64
  - The SAP HANA backup ID for log backup.
- startTime: DateTime
  - Start time for log backup.
- doesContainCatalogFile: System.Boolean
  - True if the log backup has catalog backup.
- files: list of SapHanaLogBackupFiless
  - Files in the log backup.
