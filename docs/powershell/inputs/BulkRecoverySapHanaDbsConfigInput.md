### BulkRecoverySapHanaDbsConfigInput


- recoveryPoint: DateTime
  - Required. The time to which the SAP HANA database has to be recovered.
- dbIds: list of System.Strings
  - Required. 
- sapHanaSystemCopyMap: list of SapHanaSystemCopyConfigInputs
  - The map of source and target database IDs for system copy.
