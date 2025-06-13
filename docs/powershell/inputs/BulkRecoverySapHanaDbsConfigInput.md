### BulkRecoverySapHanaDbsConfigInput


- recoveryPoint: DateTime
  - Required. The time to which the SAP HANA database has to be recovered.
- dbIds: list of System.Strings
  - Required. 
- isAfter: System.Boolean
  - Required. If true, the databases will be recovered to the nearest recovery point available after the specified time. If false, the databases will be recovered to the nearest recovery point available before the specified time.
- sapHanaSystemCopyMap: list of SapHanaSystemCopyConfigInputs
  - The map of source and target database IDs for system copy.
- shouldInitializeLogArea: System.Boolean
  - Required. If you do not want to recover the log segments residing in the log area, set this boolean to true. After the recovery, the log entries will be deleted from the log area. Always initialize the log area in case of a system-copy restore.
