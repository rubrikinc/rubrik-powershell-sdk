### RecoverToPointInTimeSapHanaDbConfigInput
Supported in v9.4+

- sourceDbConfig: SapHanaRestoreSourceConfigInput
  - Supported in v9.4+
- shouldInitializeLogArea: System.Boolean
  - Required. Supported in v9.4+
If you do not want to recover the log segments residing in the log area, set this boolean to true. After the recovery, the log entries will be deleted from the log area. Always initialize the log area in case of a system-copy restore.
- recoveryPoint: DateTime
  - Supported in v9.4+
The time to which the SAP HANA database has to be recovered.
- dbId: System.String
  - Required. Supported in v9.4+
The database ID that you want to recover.
- lssPassword: System.String
  - The Local Secure Store (LSS) backup encryption password. Required for restoring backups created with LSS encryption enabled. This password is not stored and is only used during the restore operation.
