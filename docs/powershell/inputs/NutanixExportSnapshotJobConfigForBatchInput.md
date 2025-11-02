### NutanixExportSnapshotJobConfigForBatchInput
Supported in v7.0+

- exportConfig: NutanixVmExportSnapshotJobConfigInput
  - Required. Supported in v7.0+
Configuration used for exporting the snapshot.
- snapshotAfterDate: DateTime
  - Supported in v7.0+
Exports the oldest snapshot taken after the specified date. 'snapshotAfterDate' is only evaluated when no values are set for 'snapshotId' and 'snapshotBeforeDate'.
- snapshotBeforeDate: DateTime
  - Supported in v7.0+
Exports the snapshot taken most recently prior to the specified date. 'snapshotBeforeDate' is only evaluated when no value is set for 'snapshotId'.
- snapshotId: System.String
  - Supported in v7.0+
ID of the snapshot to export. This parameter is optional if the 'snapshotBeforeDate' or 'snapshotAfterDate' parameters are configured.
- vmId: System.String
  - Required. Supported in v7.0+
ID of the virtual machine with the snapshot that requires exporting.
- vmNamePrefix: System.String
  - Supported in v7.0+
Prefix added to the name of the exported virtual machine.
