### DatabaseLogRetentionConfigEntry
A single workload-to-log-retention-policy entry. Pairs a workload
type (e.g. "mssql", "oracle_database") with its retention policy
for the parent archival or replication location.

- workloadType: System.String
  - The database workload type. Canonical values are "mssql" and
"oracle_database"; must be unique within the parent entry list.
- config: DatabaseLogRetentionConfig
  - Log retention policy for this workload type.
