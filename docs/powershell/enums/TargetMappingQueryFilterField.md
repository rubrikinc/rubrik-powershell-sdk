### TargetMappingQueryFilterField
Target mapping filter field.

- NAME - Filter by target mapping name.
- ARCHIVAL_GROUP_TYPE - Filter by target mapping type.
- ARCHIVAL_LOCATION_TYPE - Filter by target mapping type.
- EXCLUDE_ARCHIVAL_LOCATION_TYPE - Filter by excluding target type.
- CLOUD_ACCOUNT_ID - Filter by cloud account ID.
- ARCHIVAL_GROUP_ID - Filter by target mapping ID.
- CLOUD_NATIVE_USE_CASE - Filter by cloud native use case.
- EXCLUDE_GROUP_TYPE - Filter to exclude group types.
- INCLUDE_INLINE - Filter to include inline groups.
- COMPATIBLE_SNAPPABLE_TYPES - Filter archival groups to only those compatible with the listed
snappable types. text_list values must be SlaObjectType enum names
(e.g. "AWS_EC2_EBS_OBJECT_TYPE"). Groups containing CSE-enabled
archival locations are filtered out when the corresponding UEM
feature flag is not enabled for the snappable types.
