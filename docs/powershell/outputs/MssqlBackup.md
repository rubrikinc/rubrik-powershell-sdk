### MssqlBackup
Supported in v5.2+

- backupId: System.String
  - Required. Supported in v5.2+
The unique identifier for the object.
- backupSize: System.Int64
  - Required. Supported in v5.2+
The total uncompressed size of the files in bytes.
- backupType: MssqlBackupType
  - Required. Supported in v5.2+
The type of backup. Backup types can be snapshots or logs.
- date: DateTime
  - Supported in v5.2+
Timestamp of the backup.
- lsn: System.String
  - Required. Supported in v5.2+
LSN of the backup.
- path: System.String
  - Required. Supported in v5.2+
The file path the backup will be stored at in downloaded zip files containing it.
- recoveryForkGuid: System.String
  - Required. Supported in v5.2+
GUID of the recovery fork attached to the LSN.
