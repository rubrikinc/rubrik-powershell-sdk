### HypervExportSnapshotJobConfigForBatchInput
Supported in v7.0+

- snapshotAfterDate: DateTime
  - Supported in v7.0+
      Exports the oldest snapshot taken after the specified date. snapshotAfterDate is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v7.0+
      Exports the snapshot most recently taken prior to the specified date. snapshotBeforeDate is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v7.0+
      ID of the snapshot to export. This parameter is optional if the snapshotBeforeDate or snapshotAfterDate parameters are configured.
- vmNamePrefix: System.String
  - Supported in v7.0+
      Prefix to be added to the name of the exported virtual machine.
- exportConfig: HypervExportSnapshotJobConfigInput
  - Required. Supported in v7.0+
      Configuration for exporting the snapshot.
- vmId: System.String
  - Required. Supported in v7.0+
      ID of the virtual machine with snapshot that requires exporting.
