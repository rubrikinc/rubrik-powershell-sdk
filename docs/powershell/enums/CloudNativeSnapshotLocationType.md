### CloudNativeSnapshotLocationType
Preferred snapshot location type for recovery
workflows. Mirrors resmap.SnapshotLocationType to
avoid a circular proto dependency.

- CN_SNAPSHOT_LOCATION_AUTOMATIC - Default (no location type chosen).
- CN_SNAPSHOT_LOCATION_LOCAL - Local (primary) copy of the snapshot.
- CN_SNAPSHOT_LOCATION_REPLICATED - Replica copy of the snapshot.
- CN_SNAPSHOT_LOCATION_EXTERNAL_ARCHIVE - Customer managed archival copy.
- CN_SNAPSHOT_LOCATION_RCV_PREMIUM - RCV Premium Tier copy.
