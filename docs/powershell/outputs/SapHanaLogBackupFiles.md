### SapHanaLogBackupFiles
Log backup file for SAP HANA log backup.

- backupId: System.Int64
  - The SAP HANA backup ID for log backup.
- backupSizeInBytes: System.Int64
  - Size of the backup in bytes.
- destinationPath: System.String
  - Displays that the data or log backup was written to this location.
- destinationType: System.String
  - Type of location: file or backint.
- externalBackupId: System.String
  - Identifier of the log backup.
- hostName: System.String
  - Name of the host.
- logPositionInterval: SapHanaLogPositionInterval
  - New and old redo log positions.
- serviceTypeName: System.String
  - Type of database service: indexserver, nameserver, or statisticsserver.
- sourceId: System.Int64
  - The persistence volume ID.
- sourceTypeName: System.String
  - Type of persistence to be backed-up: volume or topology.
