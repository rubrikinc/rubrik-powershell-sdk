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
- storageSetting: TargetMapping
  - Storage settings of an archival group.
- archivalLocationToClusterMapping: list of ArchivalLocationToClusterMappings
  - Mapping between the archival location and the Rubrik cluster.
