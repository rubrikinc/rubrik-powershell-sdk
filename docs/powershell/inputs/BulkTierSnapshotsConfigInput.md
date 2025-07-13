### BulkTierSnapshotsConfigInput
Supported in v6.0+

- locationId: System.String
  - Supported in v6.0+
Users can specify the archival location ID in order to tier snapshots in the specified archival location. When an archival location ID is not specified, snapshots in the archival location specified in the SLA Domain policy for protected objects will be tiered. Relic and unprotected object snapshots across all archival locations will be tiered.
- objectIds: list of System.Strings
  - Required. Supported in v6.0+
A list of object IDs to tier.
