### ArchivalSpecInput
Archiving specification.

- archivalGroupId: System.String
  - ID of the archival group.
- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
- archivalTieringSpecInput: ArchivalTieringSpecInput
  - Archival tiering specification.
- frequencies: list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- archivalLocationToClusterMapping: list of ArchivalLocationToClusterMappingInputs
  - Mapping between archival location and Rubrik cluster.
- isComplianceImmutabilityEnabled: System.Boolean
  - DEPRECATED: Compliance immutability for CNP has been reverted.
This field is no longer read or written.
- databaseLogRetentionInfo: DatabaseLogRetentionInfo
  - Per-workload database transaction log retention policy for this location.
