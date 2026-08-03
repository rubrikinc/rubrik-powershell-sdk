### FieldEnum
Field identifies which snapshot attribute a filter clause applies to.

- ALL - ALL applies no filter and returns all snapshots.
- IS_EXPIRED - IS_EXPIRED filters snapshots by expiry state.
- IS_HINT_SET - IS_HINT_SET filters snapshots by whether an expiry hint time is set.
- IS_ON_DEMAND - IS_ON_DEMAND filters snapshots by whether they are on-demand.
- IS_INDEXED - IS_INDEXED filters snapshots by index state.
- IS_INDEX_MERGED - IS_INDEX_MERGED filters snapshots by whether their index has been merged.
- IS_DELETED_FROM_SOURCE - IS_DELETED_FROM_SOURCE filters snapshots by whether their source object
has been deleted.
- IS_COMPLETE - IS_COMPLETE filters snapshots by completion state.
- TIME_RANGE_WITH_OFFSET - TIME_RANGE_WITH_OFFSET filters snapshots to a time range with an offset.
- IS_CORRUPTED - IS_CORRUPTED filters snapshots by whether they are corrupted.
- IS_SKIPPED_FOR_REPLICATION - IS_SKIPPED_FOR_REPLICATION filters snapshots by whether they are skipped
for replication.
- IS_REPLICA - IS_REPLICA filters snapshots by whether they are replicas.
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
- SNAPSHOT_IDS - When configured, it returns snapshots with IDs present in the list.
- SEQUENCE_NUMS - SEQUENCE_NUMS will only return results matching one of the sequence
numbers in the list.
- ARCHIVAL_LOCATION_IDS - ARCHIVAL_LOCATION_IDS will only return results matching one of the
archival locations in the list.
