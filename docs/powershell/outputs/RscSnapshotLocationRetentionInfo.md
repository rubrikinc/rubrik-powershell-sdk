### RscSnapshotLocationRetentionInfo
RSC snapshot location retention information.

- isSnapshotPresent: System.Boolean
  - Specifies whether the snapshot is present at this location.
- isExpirationDateCalculated: System.Boolean
  - Specifies whether the expiration date for this snapshot has been calculated. This field will be absent if the snapshot has never existed at this location.
- expirationTime: DateTime
  - Time when the snapshot expired or is expected to expire at this location.
- locationId: System.String
  - Location ID of snapshot.
- locationName: System.String
  - Location name of snapshot.
