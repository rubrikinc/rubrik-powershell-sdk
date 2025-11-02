### RestoreNutanixVmSnapshotFilesFromArchivalLocationInput


- config: NutanixRestoreFilesConfigInput
  - Required. Configuration for a job to restore files to a source Nutanix virtual machine.
- snapshotId: System.String
  - Required. v8.0: ID of Nutanix VM snapshot.
v8.1+: ID of Nutanix virtual machine snapshot.
- locationId: System.String
  - Required. ID of the archival location.
