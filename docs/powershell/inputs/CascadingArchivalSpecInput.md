### CascadingArchivalSpecInput
Cascading archiving specification.

- archivalLocationId: System.String
  - CDM archival location on the replication target where the snapshot is uploaded. Deprecated: use archivalLocationToClusterMapping instead.
- archivalThreshold: SlaDurationInput
  - Threshold after which the snapshot will be archived.
- archivalTieringSpecInput: ArchivalTieringSpecInput
  - Archival tiering specification input.
- frequency: list of RetentionUnits
  - Frequencies that are associated with this cascaded archival location.
- archivalLocationToClusterMapping: list of ArchivalLocationToClusterMappingInputs
  - Mapping between archival location and Rubrik cluster.
