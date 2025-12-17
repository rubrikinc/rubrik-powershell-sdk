### RcvBliMigrationFilter
Filter for listing Blob immutability migration details of RCV Azure locations.

- migrationStatuses: list of BliMigrationStatuss
  - Filter by BLI migration status.
- clusterIds: list of System.Strings
  - Filter by cluster ID.
- tiers: list of RcvTiers
  - Filter by tier of the location.
- regions: list of RcvRegionInputs
  - Filter by region of the location.
- locationStatuses: list of ArchivalLocationStatuss
  - Filter by location status.
- unavailabilityReasons: list of MigrationUnavailabilityReasons
  - Filter by unavailability reason.
- searchByLocationName: System.String
  - Search text to filter locations by name (optional).
Performs a case-insensitive substring match on location name.
