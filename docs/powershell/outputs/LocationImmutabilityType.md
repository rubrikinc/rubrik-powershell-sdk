### LocationImmutabilityType
View of location immutability settings exposed in the GraphQL schema.
Combines DLS-provided settings with NCD immutability mode.

- bucketLockDurationDays: System.Int32
  - Number of days location is immutable.
- isObjectLockEnabled: System.Boolean
  - Specifies whether object-level immutability is enabled.
- immutabilityMode: ArchivalLocationImmutabilityMode
  - Immutability mode for this target. Absent when the target does not enforce mode-based immutability.
