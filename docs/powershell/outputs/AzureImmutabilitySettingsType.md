### AzureImmutabilitySettingsType
Immutability settings for azure cdm target.

- lockDurationDays: System.Int32
  - Number of days location is immutable.
- isBlobImmutabilityEnabled: System.Boolean
  - Specifies whether blob-level immutability is enabled.
- immutabilityMode: ArchivalLocationImmutabilityMode
  - Immutability mode for this target. Absent when the target does not enforce mode-based immutability.
