### RcvBliMigrationDetails
RcvBliMigrationDetails is the object for holding blob immutability migration
details of a RCV Azure location.

- migrationStatus: System.String
  - Current status of blob immutability migration for this location.
- locationId: System.String
  - Location ID of the location.
- locationName: System.String
  - Name of the location.
- clusterName: System.String
  - Name of the cluster associated with the location.
- tier: RcvTier
  - Tier of the location.
- rcvRegion: RcvRegion
  - Region of the location.
- locationStatus: ArchivalLocationStatus
  - Availability status of the location.
- migrationUnavailabilityReason: System.String
  - Reason for the location being unavailable for migration.
- storageConsumedBytes: System.Int64
  - Total bytes used on the archival location.
- bliMigrationStatus: BliMigrationStatus
  - Current status of blob immutability migration for this location.
- bliMigrationUnavailabilityReason: MigrationUnavailabilityReason
  - Reason for the location being unavailable for migration.
