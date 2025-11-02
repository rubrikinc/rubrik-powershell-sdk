### OracleDbSnapshotSummary
Supported in v5.0+

- databaseName: System.String
  - Required. Supported in v5.0+
- tablespaces: list of System.Strings
  - Required. Supported in v5.0+
Array containing descriptions of the tablespaces that were captured in the specified snapshot.
- isValid: System.Boolean
  - Supported in v5.3+
A Boolean that specifies whether the snapshot is valid.
- hostOrRacManagedId: System.String
  - Supported in v8.1+
Managed ID of the host or RAC from where the database snapshot is taken.
- hostOrRacName: System.String
  - Supported in v8.1+
Hostname or RAC name from where the database snapshot is taken.
- baseSnapshotSummary: BaseSnapshotSummary
  - The base information of a snapshot that is common across other workloads.
