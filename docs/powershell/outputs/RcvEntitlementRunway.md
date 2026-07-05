### RcvEntitlementRunway
Aggregate forecast metrics and projected runway for one RCV
entitlement group.

- tier: RcvTier
  - Tier of this entitlement group.
- redundancy: RcvRedundancy
  - Redundancy level of this entitlement group.
- currentBytes: System.Single
  - Sum of current archival storage (bytes) across the group's
locations.
- weeklyGrowthPct: System.Single
  - Weighted-average weekly growth rate (percent) across the
group's locations, weighted by each location's current bytes.
- runwayDays: System.Single
  - Projected number of days until the group's used capacity
reaches its entitled capacity at the current growth rate. Set
to -1 when growth is non-positive, when capacity is already
exhausted, or when no forecast data is available for any
location in the group.
- lastRefreshedAt: DateTime
  - Timestamp of the most recent forecast refresh for the group.
Unset when no forecast data is available yet.
