### CloudDirectSnapshotLocationRetentionInfo
NAS CloudDirect snapshot location retention information.

- locationId: System.String
  - ID of the snapshot location.
- name: System.String
  - Name of the snapshot location.
- isSnapshotPresent: System.Boolean
  - Specifies whether the snapshot is present at this location.
- isExpirationDateCalculated: System.Boolean
  - Specifies whether the expiration date for this snapshot has been calculated. This field will be absent if the snapshot has never existed at this location.
- expirationTime: DateTime
  - Time when the snapshot expired or is expected to expire at this location.
- isSnapshotOnLegalHold: System.Boolean
  - Boolean to indicate whether the snapshot is legally held at the specified location.
