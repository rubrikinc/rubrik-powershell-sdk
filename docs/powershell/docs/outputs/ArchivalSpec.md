### ArchivalSpec
Archiving specification.

- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequencies: list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- archivalLocationToClusterMapping: list of ArchivalLocationToClusterMappings
  - Mapping between archival location and Rubrik cluster.
- storageSetting: TargetMapping
  - Storage settings of an archival group.
