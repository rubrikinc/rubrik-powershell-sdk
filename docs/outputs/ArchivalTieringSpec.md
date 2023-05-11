### ArchivalTieringSpec
Archival tiering specification.

- coldStorageClass: ColdStorageClass
  - Cold storage class for tiering.
- isInstantTieringEnabled: System.Boolean
  - True when instant tiering enabled.
- minAccessibleDurationInSeconds: System.Int64
  - Minimum accessible duration specified for smart tiering.
- shouldTierExistingSnapshots: System.Boolean
  - Tier existing snapshots for instant tiering, when true.
