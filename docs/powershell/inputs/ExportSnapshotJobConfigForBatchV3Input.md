### ExportSnapshotJobConfigForBatchV3Input
Supported in Rubrik CDM version 9.0 and later. Input for batch export snapshots for vSphere.

- snapshotAfterDate: DateTime
  - Supported in v8.1+
      Exports the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Supported in v8.1+
      Exports the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - Supported in v8.1+
      The ID of the snapshot to export. This parameter is optional if either of the snapshotBeforeDate or snapshotAfterDate parameters is configured.
- vmNamePrefix: System.String
  - Supported in v8.1+
      Prefix to be added to the name of the exported virtual machine.
- config: ExportSnapshotJobConfigV3Input
  - Required. Supported in v8.1+
      Configuration for snapshot export.
- vmId: System.String
  - Required. Supported in v8.1+
      ID of the virtual machine whose snapshot needs to be exported.
