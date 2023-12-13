### FieldEnum
- ALL
- IS_EXPIRED
- IS_HINT_SET
- IS_ON_DEMAND
- IS_INDEXED
- IS_INDEX_MERGED
- IS_DELETED_FROM_SOURCE
- IS_COMPLETE
- TIME_RANGE_WITH_OFFSET
- IS_CORRUPTED
- IS_SKIPPED_FOR_REPLICATION
- IS_REPLICA
- HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS - When true, returns snapshots that have unexpired archived snapshots.
 When false, returns snapshots that do not have any unexpired archived
 snapshots.
- SEQUENCE_NUMBER_GREATER_THAN - Returns snapshots with a sequence number greater than the
 specified sequence number.
- HAS_UNEXPIRED_ARCHIVED_OR_SOURCE_SNAPSHOTS - When true, returns unexpired snapshots or snapshots that
 have unexpired archived snapshots.
 When false, returns expired snapshots and snapshots that
 do not have any unexpired archived snapshots.
- HAS_UNEXPIRED_ARCHIVED_OR_UNGCED_SOURCE_SNAPSHOTS - When true, returns unGCed snapshots (may/may not have expiry hint time
 set) or snapshots that have unexpired archived snapshots.
 When false, returns GCed snapshots that do not have any unexpired
 archived snapshots.
 Note that this filter is only for source snapshots, so it is
 incompatible with IS_REPLICA = true. No snapshots would be returned in
 that case.
- SPECIFIC_SNAPSHOT_NOT_REQUIRED - SPECIFIC_SNAPSHOT_NOT_REQUIRED when added as a filter returns Snapshots
 without the specific snapshots details. When not provided, Specific
 Snapshot details are returned. Add the filter for efficiency if specific
 snapshot details are not required.
