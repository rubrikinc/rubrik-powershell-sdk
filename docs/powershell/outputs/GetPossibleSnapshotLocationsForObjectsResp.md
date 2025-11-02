### GetPossibleSnapshotLocationsForObjectsResp
GetPossibleSnapshotLocationsForObjectsResp is the response for
GetPossibleSnapshotLocationsForObjects query.

- snapshotLocations: list of SnapshotLocations
  - List of locations on which snapshots of the requested objects are present.
- hasNext: System.Boolean
  - Indicates if there are more locations available beyond the current page.
Default value is false if not explicitly set by the server.
