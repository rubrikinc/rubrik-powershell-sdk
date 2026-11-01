### RecoveryCheck
Identifies which specific CCES recovery pre-flight check produced a finding.

- UNSPECIFIED - Default value. The finding is not tied to a specific pre-flight check.
- NODE_NOT_TERMINATED - Node state checks
- NODE_STATE_UNKNOWN - The state of a cluster node could not be determined.
- CERT_TARBALL_MISSING - Bucket content checks
- SNAPSHOT_MISSING - A required snapshot is missing from the cluster bucket.
- SHARD_INCOMPLETE - A shard in the cluster bucket is incomplete.
- DATA_LOCATION_ID_INVALID - The data location ID of the cluster is not valid.
- CDC_COVERAGE_GAP - Change data capture (CDC) coverage has a gap.
- SNAPSHOT_STALE - The latest snapshot in the cluster bucket is stale.
- BUCKET_ACCESS_DENIED - Access to the cluster bucket was denied.
