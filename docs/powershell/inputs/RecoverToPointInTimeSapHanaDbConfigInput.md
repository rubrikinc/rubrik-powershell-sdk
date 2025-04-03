### RecoverToPointInTimeSapHanaDbConfigInput


- recoveryPoint: DateTime
  - Required. The time to which the SAP HANA database has to be recovered.
- dbId: System.String
  - Required. The database ID that you want to recover.
- shouldInitializeLogArea: System.Boolean
  - Required. If you do not want to recover the log segments residing in the log area, set this boolean to true. After the recovery, the log entries will be deleted from the log area. Always initialize the log area in case of a system-copy restore.
- sourceDbConfig: SapHanaRestoreSourceConfigInput
  - 
