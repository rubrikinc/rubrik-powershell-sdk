### PendingSLAsToBeUpgradedRes
Response containing the list of SLA Domains that are pending upgrade.

- slas: list of SLAUpgradeIneligibilitys
  - List of SLA Domain that are pending upgrade.
- userPendingUpgradableCount: System.Int32
  - Number of pending SLA that can be upgraded by user.
- totalPendingUpgradableCount: System.Int32
  - Total number of pending SLA that can be upgraded in account.
- clustersWithPendingCount: System.Int32
  - Total number of Rubrik clusters with pending SLA Domains that must be upgraded.
