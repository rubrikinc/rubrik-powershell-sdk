### CdmSnapshotLocationRetentionInfo
CDM snapshot location retention information.

- expirationTime: DateTime
  - Supported in v5.2+
  Time when the snapshot expired or is expected to expire at this location. This field will only be set if the snapshot has ever existed at the location. If the snapshot is present at the location, but the expiration time calculation is pending, this field will be absent. If the expiration time calculation is complete and the field is still absent, the snapshot will be retained forever at this location.
- isExpirationDateCalculated: System.Boolean
  - Supported in v5.2+
  A Boolean that indicates whether expiration date for snapshot has been calculated. This field will be absent if the snapshot has never existed at this location.
- isExpirationInformationUnavailable: System.Boolean
  - Supported in v5.2+
  Indicates whether expiration information of the snapshot is unavailable at this location. This field is always and only present for replication locations. Its value is true if and only if the replicated snapshots are from pre-5.2 cluster.
- isSnapshotPresent: System.Boolean
  - Required. Supported in v5.2+
  Boolean that specifies whether the snapshot is present at this location. When this value is 'false,' the snapshot is expired at this location. Because retention information is unreliable for locations where the snapshots are not present, confirming that this value is 'true' is the best practice.
- locationId: System.String
  - Location ID for snapshot retention.
- name: System.String
  - Required. Supported in v5.2+
  Name of the location.
- snapshotFrequency: SnapshotFrequency
  - Supported in v5.2+
  The tag to determine what frequency the snapshot corresponds to at this location. The snapshot tag can be hourly, daily, weekly, monthly, quarterly, or yearly depending on the SLA frequency which is used to determine the retention of the snapshot. A value of "Ready for Deletion" means that the snapshot will be deleted soon. A value of "Forever" means that the snapshot will never be deleted. This field is absent when the tag computation is incomplete.
