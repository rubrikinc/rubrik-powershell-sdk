### SlaSyncStatus
Status of the latest attempt to sync the SLA Domain to the clusters.

- FAILED - Sync failed.
- PENDING - Sync pending.
- SUCCEEDED - Sync successful.
- NOT_ATTEMPTED - Sync not attempted.
- PARTIAL_SYNC_SUCCESS - Sync completed with partial success. Some SLA properties were not synced due to
cluster version limitations (e.g., kill switch not supported on clusters < 9.5.1).
