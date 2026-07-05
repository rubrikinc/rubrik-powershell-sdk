### PermissionsGroupWithVersion
Represents a permissions group with its version.

- permissionsGroup: PermissionsGroup
  - Represents the permissions group.
- version: System.Int32
  - Represents the version of the permissions group.
- deltaInterval: list of DeltaIntervals
  - Delta intervals applied. Populated when the PG is on the
delta-intervals representation; empty otherwise.
- deltaMigrated: System.Boolean
  - True iff this PG is on the delta-intervals representation;
when false, read `version` and ignore `delta_interval`.
