### SapHanaDataBackupFile
Data backup files for SAP HANA full, incremental, or differential backup.

- backupFileSizeInBytes: System.Int64
  - Size of the backed-up file in bytes.
- destinationPath: System.String
  - Path of the target location where the data or log backup was written.
- externalBackupId: System.String
  - Identifier of the data backup.
- redoLogPositionOpt: System.Int64
  - Redo log position for the backup.
- serviceType: System.String
  - Type of database service: indexserver, nameserver, or statisticsserver.
- sourceId: System.Int64
  - The persistence volume ID.
- sourceType: System.String
  - Type of persistence to be backed-up: volume or topology.
