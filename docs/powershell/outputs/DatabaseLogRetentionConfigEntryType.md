### DatabaseLogRetentionConfigEntryType
A single workload-to-log-retention-policy entry. Pairs a workload
type (e.g. "mssql") with its retention policy for the parent
archival or replication location.

- workloadType: System.String
  - The database workload type. Canonical value is "mssql";
must be unique within the parent entry list.
- config: DatabaseLogRetentionConfigType
  - Log retention policy for this workload type.
