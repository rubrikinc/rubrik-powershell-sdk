### AwsImmutabilitySettingsType
Immutability settings for aws cdm target.

- lockDurationDays: System.Int32
  - Number of days location is immutable.
- isObjectLockEnabled: System.Boolean
  - Specifies whether object-level immutability is enabled.
- immutabilityMode: ArchivalLocationImmutabilityMode
  - Immutability mode for this target. Absent when the target does not enforce mode-based immutability.
