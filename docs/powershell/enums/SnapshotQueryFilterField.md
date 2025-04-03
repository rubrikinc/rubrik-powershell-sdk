### SnapshotQueryFilterField
Filters to query snapshots.

- SLA_ID - There is no concept of SLA ID on a snapshot. Hence, this
filter field is deprecated and would be removed subsequently.
- IS_ON_DEMAND
- IS_DOWNLOADED
- SNAPSHOT_TYPE - Field to filter based on snapshot types. Snapshot types can only
be on-demand or scheduled.
- IS_SAP_HANA_INCREMENTAL_SNAPSHOT - When true, returns incremental snapshots of SAP HANA
workload. When false, returns full snapshots.
- IS_DELETED_FROM_SOURCE - When true, returns snapshots that are deleted from source.
- IS_REPLICA - Denotes whether the snapshot is a replica copy or not.
- EC2_AWS_NATIVE_ACCOUNT_ID - Returns all AWS EC2 snapshots from the specified AWS account.
- EBS_AWS_NATIVE_ACCOUNT_ID - Returns all AWS EBS snapshots from the specified AWS account.
- IS_ARCHIVED - When the value is true, this filter returns snapshots that are archived.
- IS_GCED - When true, returns snapshots that have been deleted, else
returns all non-deleted snapshots (may/may not be expired).
- ARCHIVAL_LOCATION_IDS - A comma-separated list of archival location IDs. Returns snapshots from
all archival locations corresponding to the specified IDs.
- IS_LEGALLY_HELD - When true, returns snapshots that have been placed on legal
hold, else return all snapshots which are not legally held.
- HAS_CLOUD_NATIVE_INDEX_FILES - When true, returns snapshots for which index files are present,
i.e. either the index storage path is present or there have been indexing
attempts on the snapshot.
Note: In case of cloud native indexing failures(indexing attempts > 0),
some indexing status log files are stored at the location where index
files are usually stored.
- HAS_UNEXPIRED_REPLICAS - When the value is true, this filter returns snapshots with one or more
unexpired replicas.
- HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS - When the value is true, returns snapshots with one or more unexpired
archived snapshots.
- SNAPPABLE_TYPES - List of protectable object types. When this list is configured with
object types, it returns snapshots of that type.
- IS_APPFLOWS_QUERY_SNAPSHOT_DETAILS_NOT_NEEDED - Does not return AppFlows-related details for the snapshots.
- IS_SKIPPED_FOR_REPLICATION - When true, returns snapshots that were skipped for
replication. When false, returns snapshots which were not skipped.
- ON_DEMAND_SLA_ID - When the filter text list is provided, returns all on-demand snapshots
that are assigned any of the given SLA Domain IDs.
Note: text field will not be used for this filter.
- IS_REPLICATED - When true, returns snapshots that have been replicated.
When false, returns snapshots which have not been replicated.
- SNAPSHOT_STATUS - Returns snapshots for which the snapshot_status field is in
the specified state. This is a text field.
- IMMUTABLE_LOCK_END_TIME_BEFORE - Returns the entries where value of lock_end_time column is null or
is less than the the provided time in the field time.
- IS_ARCHIVAL_COPY - When true, this filter returns the snapshots created as a result of
archiving source snapshots. When false, the filter returns snapshots
that were not created due to archiving.
- IS_INDEXED - When true, this returns snapshots that have been indexed, else
returns snapshots that have not been indexed.
- IS_NOT_GLOBALLY_EXPIRED - When true, returns source snapshots that are not globally expired
i.e. snapshot is unexpired on source or has an unexpired replica/archival
copy, else returns globally expired source snapshots.
- RDS_AWS_NATIVE_ACCOUNT_ID - Returns all AWS RDS snapshots from the specified AWS account.
- EXCLUDE_QUARANTINED - When true, returns snapshots that are not quarantined.
- EXCLUDE_ANOMALOUS - When true, returns snapshots that are not anomalous.
- SNAPSHOT_CUSTOMIZATION - Field to filter based on snapshot customization.
- HAS_UNEXPIRED_ARCHIVED_OR_UNGCED_SOURCE_SNAPSHOTS - When true, returns unGCed snapshots (may/may not have expiry hint time
set) or snapshots that have unexpired archived snapshots.
When false, returns GCed snapshots that do not have any unexpired
archived snapshots.
Note that, in either case, it only returns source snapshots.
- IS_MARKED_FOR_METADATA_DELETION - Checks whether the death_time field is null or not. Determines
whether the snapshot metadata is marked for deletion or not.
Applicable only for snapshots of RSC workloads.
- SOURCE_SNAPSHOT_IDS - Finds snapshots that have the passed IDs as the source snapshot IDs.
Applicable only for snapshots of RSC workloads.
- IS_SOURCE_SNAPSHOT - When true, returns only source snapshots; when false,
returns snapshots that are not source snapshots.
- QUARANTINED_ONLY - When true, returns snapshots that are quarantined.
- ANOMALOUS_ONLY - When true, returns snapshots that are anomalous.
- IS_ON_DEMAND_OR_CUSTOMISED_SNAPSHOT - When true, returns snapshots which are either on-demand or customised;
when false, returns snapshots that are only policy-based.
