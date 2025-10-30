### RestoreOpenstackVmSnapshotFilesInput
Input for restoring files from an OpenStack virtual machine snapshot.

- id: System.String
  - Required. ID assigned to an OpenStack virtual machine snapshot object.
- config: OpenstackRestoreFilesConfigInput
  - Required. Details containing file paths and target virtual machine information for the restore operation.
