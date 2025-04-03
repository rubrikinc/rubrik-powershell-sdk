### SecurityMetadata
Represents security metadata of a workload.

- lowSensitiveHits: System.Int64
  - Total hits with low sensitivity.
- mediumSensitiveHits: System.Int64
  - Total hits with medium sensitivity.
- highSensitiveHits: System.Int64
  - Total hits with high sensitivity.
- sensitivityStatus: SensitivityStatus
  - Sensitivity status of a workload.
- isLaminarEnabled: System.Boolean
  - True if Laminar is enabled for a given workload.
- dataTypeResults: list of DataTypeResultss
  - List of identified data types with their total and violated hit counts.
