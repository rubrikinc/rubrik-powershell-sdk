### RdsInstanceClassBatchResult
Result for a single DB engine/version combination in a batch query.

- dbEngine: AwsNativeRdsDbEngine
  - The database engine (e.g., MYSQL, POSTGRES).
- dbEngineVersion: System.String
  - The database engine version. None if query was for all versions of the engine.
- instanceClasses: list of System.Strings
  - List of supported DB instance classes for this combination.
