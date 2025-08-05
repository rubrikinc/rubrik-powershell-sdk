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
  - Specifies whether compliance immutability, a fixed immutability lock for the retention period, is enabled for snapshot archiving to this location. It can be enabled for Compliance Retention Lock SLA Domains.
