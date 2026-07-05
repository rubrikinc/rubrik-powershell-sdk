### CascadingArchivalSpec
Cascading archival specification info.

- archivalThreshold: Duration
  - Threshold after which the snapshot will be archived.
- archivalTieringSpec: ArchivalTieringSpec
  - Archival tiering specification.
- frequency: list of RetentionUnits
  - Frequencies that are associated with this cascaded archival location.
- archivalLocationToClusterMapping: list of CascadingArchivalLocationToClusterMappings
  - Mapping between the archival location and the Rubrik cluster.
- archivalLocation: Target
  - Archival location for snapshot on target.
