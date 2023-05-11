### ArchivalSpecInput
Archiving specification.

- archivalGroupId: System.String
  - ID of the archival group.
- archivalLocationToClusterMapping: a list of ArchivalLocationToClusterMappingInputs
  - Mapping between archival location and Rubrik cluster.
- archivalTieringSpecInput: ArchivalTieringSpecInput
  - Archival tiering specification.
- frequencies: a list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
