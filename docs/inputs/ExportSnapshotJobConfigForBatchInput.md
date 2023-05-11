### ExportSnapshotJobConfigForBatchInput
Supported in v6.0+

- config: ExportSnapshotJobConfigV2Input
  - Required. Supported in v6.0+
      Configuration for snapshot export.
- snapshotAfterDate: DateTime
  - Supported in v6.0+
      Exports the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v6.0+
      Exports the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v6.0+
      The ID of the snapshot to export. This parameter is optional if either of the snapshotBeforeDate or snapshotAfterDate parameters is configured.
- vmId: System.String
  - Required. Supported in v6.0+
      ID of the virtual machine whose snapshot needs to be exported.
- vmNamePrefix: System.String
  - Supported in v6.0+
      Prefix to be added to the name of the exported virtual machine.
