### AddVmAppConsistentSpecsInput
Input required to add Azure native virtual machine application consistency specifications.

- cancelBackupIfPreScriptFails: System.Boolean
  - Specifies whether to cancel backup if pre snapshot script failed to execute on virtual machine.
- objectType: CloudNativeVmAppConsistentObjectType
  - Object type for adding Azure native virtual machine application consistency specifications.
- postSnapshotScriptPath: System.String
  - Path of post snapshot script in VM.
- postSnapshotScriptTimeoutInSeconds: System.Int32
  - Timeout (in seconds) for post snapshot script to run in VM.
- preSnapshotScriptPath: System.String
  - Path of pre snapshot script in VM.
- preSnapshotScriptTimeoutInSeconds: System.Int32
  - Timeout (in seconds) for pre snapshot script to run in VM.
- snappableIds: a list of System.Strings
  - List of virtual machine Rubrik IDs.
