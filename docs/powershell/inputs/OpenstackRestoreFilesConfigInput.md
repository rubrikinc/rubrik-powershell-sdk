### OpenstackRestoreFilesConfigInput
Settings for restoring multiple files and folders from an OpenStack virtual machine snapshot.

- restoreConfig: list of OpenstackRestoreFileConfigInputs
  - Required. Supported in v9.5+
Array containing the full path of the source and target location for each file being restored.
- targetVmId: System.String
  - Supported in v9.5+
Workload ID of the target virtual machine, which is the destination for the recovered data.
