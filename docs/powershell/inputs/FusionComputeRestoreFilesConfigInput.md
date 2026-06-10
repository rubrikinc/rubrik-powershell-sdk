### FusionComputeRestoreFilesConfigInput
Configuration for restoring a single file or folder from backup, specifying the source path from backup and the destination path on the target virtual machine.

- restoreConfig: list of FusionComputeRestoreFileConfigInputs
  - Required. Array containing the full path of the source and target location for each file being restored.
- targetVmId: System.String
  - Workload ID of the target FusionCompute virtual machine, which is the destination for the recovered data.
