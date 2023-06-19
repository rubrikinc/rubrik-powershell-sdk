### CascadingArchivalSpec
Cascading archival specification info.

- archivalThreshold: Duration
  - Threshold after which the snapshot will be archived.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequency: list of RetentionUnits
  - Frequencies that are associated with this cascaded archival location.
- archivalLocation: Target
  - Archival location for snapshot on target.
