### RdsInstanceClassRequest
Request for querying supported DB instance classes for a specific DB engine and version combination.

- dbEngine: AwsNativeRdsDbEngine
  - The database engine (e.g., MYSQL, POSTGRES).
- dbEngineVersion: System.String
  - The database engine version. If not provided, returns all instance classes for the engine.
