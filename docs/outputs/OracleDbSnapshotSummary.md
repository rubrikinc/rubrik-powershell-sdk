### OracleDbSnapshotSummary
Supported in v5.0+

- baseSnapshotSummary: BaseSnapshotSummary
  - 
- databaseName: System.String
  - Required. Supported in v5.0+
- hostOrRacManagedId: System.String
  - Managed ID of the host or RAC from where the database snapshot is taken.
- hostOrRacName: System.String
  - Hostname or RAC name from where the database snapshot is taken.
- isValid: System.Boolean
  - Supported in v5.3+
  A Boolean that specifies whether the snapshot is valid.
- tablespaces: a list of System.Strings
  - Required. Supported in v5.0+
  Array containing descriptions of the tablespaces that were captured in the specified snapshot.
