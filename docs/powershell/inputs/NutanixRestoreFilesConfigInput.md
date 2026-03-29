### NutanixRestoreFilesConfigInput
Supported in v5.0+

- restoreConfig: list of NutanixRestoreFileConfigInputs
  - Required. Supported in v5.0+
Directory of folder to copy files into.
- targetVirtualMachineId: System.String
  - Supported in v9.0+
Workload ID of the target AHV virtual machine, which is the destination for the recovered data.
- ignoreErrors: System.Boolean
  - Supported in v9.6
Optional Boolean field specifying whether to ignore errors during restore jobs. When 'true', errors are ignored and the restore continues past individual file errors. The default value is 'false'.
