### RcvEntitlementGroupQueryInput
Per-entitlement-group input for the RCV entitlement runway query.
Identifies the group by tier and redundancy.

- tier: RcsTierEnumType
  - Tier this group represents (BACKUP, ARCHIVE, RECOVERY).
- redundancy: RcvRedundancy
  - Redundancy this group represents (SINGLE_ZONE, MULTI_ZONE,
MULTI_REGION).
