### RcvEntitlementGroup
RcvEntitlementGroup defines a set of entitlements that share
a capacity pool.

- displayName: System.String
  - Customer-facing label for the group (e.g., "RCV Archive").
- representative: RcvEntitlementGroupMember
  - The canonical member used for group identity.
- members: list of RcvEntitlementGroupMembers
  - All members of this group.
- aggregateCapacity: System.Single
  - Pre-aggregated sum of entitled capacity (TB) across all group member
entitlements.
- aggregateUsedCapacity: System.Single
  - Pre-aggregated sum of used capacity (TB) across all group member
entitlements.
- aggregateExpectedUsedCapacity: System.Single
  - Pre-aggregated sum of expected used capacity (TB) across all group member
entitlements.
