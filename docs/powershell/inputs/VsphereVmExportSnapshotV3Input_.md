### VsphereVmExportSnapshotV3Input
Supported in Rubrik CDM version 9.0 and later.

- config: ExportSnapshotJobConfigV3Input
  - Required. Configuration for the export request, including timestamp and snapshot ID fields. When the snapshot ID is passed without a timestamp, this endpoint triggers an export using the given snapshot ID. When this endpoint is passed a recovery point or a recovery point and snapshot ID, the endpoint triggers an export using the point in time (PIT) for recovery. Calling this endpoint without a recovery point or a snapshot ID triggers a PIT export that uses the most recent time available.
- id: System.String
  - Required. Virtual machine ID.
