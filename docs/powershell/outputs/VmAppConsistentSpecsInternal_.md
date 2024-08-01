### VmAppConsistentSpecsInternal
Vm Application Consistency Specs Info

- preSnapshotScriptPath: System.String
  - Path for the script to be run before taking snapshot.
- preScriptTimeoutInSeconds: System.Int32
  - Timeout value in seconds for the pre snapshot script.
- postSnapshotScriptPath: System.String
  - Path for the script to be run after taking snapshot.
- postScriptTimeoutInSeconds: System.Int32
  - Pre-snapshot script timeout in seconds.
- cancelBackupIfPreScriptFails: System.Boolean
  - Specifies whether to cancel backup if the pre-snapshot script fails.
- rbaStatus: CloudNativeRbaStatusType
  - Rubrik Backup Service status.
