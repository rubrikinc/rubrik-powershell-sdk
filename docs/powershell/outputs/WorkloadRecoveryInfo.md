### WorkloadRecoveryInfo
Workload recovery info.

- isRefreshInProgressOpt: System.Boolean
  - Whether snapshot metadata refresh is in progress.
- lastUpdatedTimeOpt: DateTime
  - Recovery infomation update time.
- locationId: System.String
  - Reader location ID.
- newWorkloadId: System.String
  - Newly assigned data source ID.
- oldWorkloadId: System.String
  - Original data source ID. Deprecated: Use set of [oldWorkloadId + oldWorkloadIds] instead for multiple old IDs mapping to the same new ID. We continue to add this to the set for backward compatibility.
- oldWorkloadIds: list of System.Strings
  - All original data source IDs. Combine this with oldWorkloadId in a set for backward compatibility.
