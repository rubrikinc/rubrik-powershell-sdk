### DatabaseLogRetentionInfo
Per-workload database transaction log retention policy for an archival or
replication location. Carries a list of per-workload policy entries
(one per supported database workload type). The list is modeled as
`repeated` rather than `map<>` because the V1 GraphQL framework does
not natively deserialize map inputs; entries must have unique
workload_type values (uniqueness is enforced by validation, not by
the proto type system).

- databaseLogRetentionConfigs: list of DatabaseLogRetentionConfigEntrys
  - Per-workload transaction log retention policy for this archival or
replication location. Each entry pairs a workload type with its
retention policy. Entry order is not significant. workload_type
values must be unique within the list.
