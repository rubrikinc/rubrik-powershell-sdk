### ClusterArchivalSpec
CDM archiving specification.

- archivalLocationId: System.String
  - Archival location ID.
- archivalLocationName: System.String
  - Archival location name.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequencies: a list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
