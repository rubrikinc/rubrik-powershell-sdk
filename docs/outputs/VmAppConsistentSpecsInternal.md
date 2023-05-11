### VmAppConsistentSpecsInternal
Vm Application Consistency Specs Info

- cancelBackupIfPreScriptFails: System.Boolean
  - Specifies whether to cancel backup if the pre-snapshot script fails.
- postScriptTimeoutInSeconds: System.Int32
  - Pre-snapshot script timeout in seconds.
- postSnapshotScriptPath: System.String
  - Path for the script to be run after taking snapshot.
- preScriptTimeoutInSeconds: System.Int32
  - Timeout value in seconds for the pre snapshot script.
- preSnapshotScriptPath: System.String
  - Path for the script to be run before taking snapshot.
- rbaStatus: CloudNativeRbaStatusType
  - Rubrik Backup Service status.
