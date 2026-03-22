### ArchivalLocationIneligibilityReason
Reason why an archival location is ineligible for adding to a
failover group.

- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSPECIFIED - Unspecified (proto3 default zero value).
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NONE - Location is eligible (no ineligibility reason).
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_OWNER - Location is not an owner (not READ_WRITE status).
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_CONNECTED - Location is not connected.
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NOT_ACTIVE - Location is not active.
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_UNSUPPORTED_TYPE - Location type is not supported for failover groups.
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_NO_READER_LOCATION - No matching reader location on the secondary cluster.
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_PRIMARY_IN_FAILOVER_GROUP - Primary location is already in a failover group.
- ARCHIVAL_LOCATION_INELIGIBILITY_REASON_SECONDARY_IN_FAILOVER_GROUP - Secondary location is already in a failover group.
