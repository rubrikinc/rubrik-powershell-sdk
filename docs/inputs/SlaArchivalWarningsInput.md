### SlaArchivalWarningsInput
Input to get SLA Archival warnings.

- archivalGroupId: System.String
  - Archival Group Id to be validated.
- archivalLocationToClusterMapping: a list of ArchivalLocationToClusterMappingInputs
  - Mapping between archival location and Rubrik cluster.
- archivalThreshold: System.Int32
  - Archival Threshold of Global Sla.
- archivalThresholdUnit: RetentionUnit
  - Archival Threshold Unit of Global Sla.
- frequencies: a list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- snapshotSchedule: GlobalSnapshotScheduleInput
  - Snapshot schedule of Global Sla.
