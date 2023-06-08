### ClusterArchivalSpec
CDM archiving specification.

- archivalLocationName: System.String
  - Archival location name.
- archivalLocationId: System.String
  - Archival location ID.
- threshold: System.Int32
  - Archival threshold.
- thresholdUnit: RetentionUnit
  - Unit of archival threshold.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequencies: list of RetentionUnits
  - Archives all snapshots taken with the specified frequency.
