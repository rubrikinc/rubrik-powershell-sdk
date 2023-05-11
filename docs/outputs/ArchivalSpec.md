### ArchivalSpec
Archiving specification.

- archivalLocationToClusterMapping: a list of ArchivalLocationToClusterMappings
  - Mapping between archival location and Rubrik cluster.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequencies: a list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- storageSetting: TargetMapping
  - Storage settings of an archival group.
- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
