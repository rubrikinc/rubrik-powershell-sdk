### ExportSnapshotJobConfigForBatchV3Input
Supported in Rubrik CDM version 9.0 and later. Input for batch export snapshots for vSphere.

- snapshotAfterDate: DateTime
  - Exports the oldest snapshot taken after the specified date. This parameter is only evaluated when no values are set for snapshotId and snapshotBeforeDate.
- snapshotBeforeDate: DateTime
  - Exports the most recent snapshot taken prior to the specified date. This parameter is only evaluated when no value is set for snapshotId.
- snapshotId: System.String
  - The ID of the snapshot to export. This parameter is optional if either of the snapshotBeforeDate or snapshotAfterDate parameters is configured.
- vmNamePrefix: System.String
  - Prefix to be added to the name of the exported virtual machine.
- config: ExportSnapshotJobConfigV3Input
  - Required. Configuration for snapshot export.
- vmId: System.String
  - Required. ID of the virtual machine whose snapshot needs to be exported.
