### ArchivalTieringSpecInput
Archival tiering specification input.

- isInstantTieringEnabled: System.Boolean
  - Set when instant tiering enabled.
- minAccessibleDurationInSeconds: System.Int64
  - Min accessible duration specified for smart tiering.
- coldStorageClass: ColdStorageClass
  - Cold storage class for tiering.
- shouldTierExistingSnapshots: System.Boolean
  - Set to tier existing snapshots for instant tiering.
