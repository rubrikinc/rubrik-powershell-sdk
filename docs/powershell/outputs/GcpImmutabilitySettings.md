### GcpImmutabilitySettings
View of GCP immutability settings exposed in the GraphQL schema.
Combines DLS-provided settings with NCD immutability mode.

- isObjectLockEnabled: System.Boolean
  - Specifies whether object-level immutability is enabled.
- immutabilityMode: ArchivalLocationImmutabilityMode
  - Immutability mode for this target. Absent when the target does not enforce mode-based immutability.
