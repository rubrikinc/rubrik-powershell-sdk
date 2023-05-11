### Db2DataBackupFile
File backed up as a part of db2 backup.

- backupFileSizeInBytes: System.Int64
  - Size of the backed up file in bytes.
- db2BackupFile: Db2WorkloadDataBackupFile
  - Information specific to Db2 and which is already not available in DBDataBackupFile.
- destinationPath: System.String
  - Backup file destination path. Path of the file in the backing storage.
