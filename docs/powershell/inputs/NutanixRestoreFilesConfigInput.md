### NutanixRestoreFilesConfigInput
Supported in v5.0+

- targetVirtualMachineId: System.String
  - Supported in v9.0+
      Workload ID of the target AHV virtual machine, which is the destination for the recovered data.
- restoreConfig: list of NutanixRestoreFileConfigInputs
  - Required. Supported in v5.0+
      Directory of folder to copy files into.
