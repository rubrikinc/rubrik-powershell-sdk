### TargetQueryFilterField
Enumerates the types of filters that can be applied when querying for
Archival Locations.

- NAME - Filter archival locations by name.
- IS_ARCHIVED - Filter archival locations by archived status. [true] for archived
locations, [false] for non-archived locations and [true, false] for
all locations.
- LOCATION_TYPE - Filter archival locations by storage provider type.
- IS_MANAGED_BY_AUTO_AG - Filter archival locations that are part of an automatically
created Archival Group. (Note: We do not use archival groups
currently).
- STATUS - Filter archival locations by status.
- CLUSTER_ID - Filter archival locations by the ID of the Rubrik cluster.
- LOCATION_SCOPE - Filter archival locations by management scope: globally or locally
managed locations.
- GROUP_NAME - Filter archival locations by archival group name. (Note: We do not
use archival groups currently).
- LOC_NAME_OR_GROUP_NAME - Filter archival locations by archival group name. (Note: We do not
use archival groups currently).
- LOCATION_TIER - Filter by tier for RCS archival location.
- LOCATION_REGION - Filter RSC archival locations by region.
- EXCLUDE_CLOUD_NATIVE - Filter to exclude Cloud Native type archival locations.
- ADDITIONAL_FIELDS_REQUIRED - Names of the additional filters required for archival location
details. These fields are enumerated in
ArchivalLocationAdditionalFields.
- LOCATION_ID - Filter archival locations by the RSC-managed ID or the CDM FID.
- ARCHIVAL_ENTITY_USE_CASE_TYPE - Filter archival locations by use case type as defined by
ArchivalEntityUseCaseType.
- EXTERNAL_CDM_LOCATION_ID - Filter archival location by the Rubrik CDM ID of the location.
- LOCATION_REDUNDANCY - Filter by redundancy for RCV archival location.
