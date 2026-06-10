### SnapshotLocation
SnapshotLocation represents the details of the location on which
snapshots of the requested objects are present.

- locationId: System.String
  - ID of the Snapshot Location.
- locationName: System.String
  - Name of the Snapshot Location.
- locationType: SnapshotLocType
  - Type of the snapshot location (cluster, archival, rehydrated).
When unavailable, defaults to SNAPSHOT_LOCATION_TYPE_UNSPECIFIED.
- snapshotCount: System.Int32
  - Number of unexpired snapshots at this location.

The aggregation semantic depends on the embedding response:
- In possibleSnapshotLocationsForObjects, the count is aggregated
across all input objects (one location -> one row, summed).
- In cdmSnapshotCountByObjectAndLocation, the count is for the
single (object, location) pair represented by that entry only.

May be null if the count is not available.
