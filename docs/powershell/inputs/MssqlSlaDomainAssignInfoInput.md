### MssqlSlaDomainAssignInfoInput
Supported in v5.1+

- existingSnapshotRetention: ExistingSnapshotRetention
  - Supported in v5.1+
- ids: list of System.Strings
  - Required. Supported in v5.1+
List of SQL Server object IDs which should be assigned these properties.
- shouldApplyToExistingSnapshots: System.Boolean
  - Supported in v7.0+
A Boolean value indicating whether to retain existing snapshots of assigned objects with the specified SLA Domain configuration. The default value is 'true'. If objects are unprotected, existing snapshots are retained according to the value of the 'existingSnapshotRetention' parameter. For unprotected objects, this value is empty. When an SLA Domain assignment is cleared from an object, the retention strategy described by the 'existingSnapshotRetention' parameter is used only when the object can inherit a protection SLA Domain from an ancestor object.
- shouldApplyToNonPolicySnapshots: System.Boolean
  - Supported in v7.0+
A Boolean value. When true, specifies that the retention changes corresponding to the new SLA Domain are applied to non-policy snapshots in addition to existing policy-based snapshots.
- mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput
  - SLA Domain properties of a SQL Server object.
