### SlaArchivalWarningsInput
Input to get SLA Archival warnings.

- snapshotSchedule: GlobalSnapshotScheduleInput
  - Snapshot schedule of Global Sla.
- archivalThreshold: System.Int32
  - Archival Threshold of Global Sla.
- archivalThresholdUnit: RetentionUnit
  - Archival Threshold Unit of Global Sla.
- archivalGroupId: System.String
  - Archival Group Id to be validated.
- archivalLocationToClusterMapping: list of ArchivalLocationToClusterMappingInputs
  - Mapping between archival location and Rubrik cluster.
- frequencies: list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
