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
