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
- isComplianceImmutabilityEnabled: System.Boolean
  - Specifies whether compliance immutability, a fixed immutability lock for the retention period, is enabled for snapshot archiving to this location. It can be enabled for Compliance Retention Lock SLA Domains.
