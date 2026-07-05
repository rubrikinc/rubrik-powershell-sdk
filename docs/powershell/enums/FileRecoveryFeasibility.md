### FileRecoveryFeasibility
Cloud-native file recovery feasibility.

- UNKNOWN - File recovery feasibility is unknown.
- FEASIBLE - File recovery is feasible.
- SNAPSHOT_EXPIRED - File recovery is not feasible because the snapshot expired.
- EXOCOMPUTE_NOT_CONFIGURED - File recovery is not feasible because Exocompute is not configured.
- UNSUPPORTED_HOSTED_REGION - Rubrik-hosted compute is not supported in the region.
- UNSUPPORTED_STORAGE_CLASS - The snapshot's only recoverable copy is on a cold S3 Glacier storage
class (Glacier Flexible Retrieval / Deep Archive) that must be rehydrated
via "Retrieve from archival tier" before file recovery.
- UNSUPPORTED_RCV_TIER - The snapshot's only recoverable copy is on the RCV ARCHIVE tier, which
must be rehydrated via "Retrieve from archival tier" before file recovery.
