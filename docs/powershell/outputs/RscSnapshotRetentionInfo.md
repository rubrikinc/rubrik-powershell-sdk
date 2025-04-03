### RscSnapshotRetentionInfo
RSC snapshot retention information for local, archival, and replication locations.

- isCustomRetentionApplied: System.Boolean
  - Specifies whether custom retention is applied on the snapshot.
- archivalInfos: list of RscSnapshotLocationRetentionInfos
  - List of snapshot retention information objects for the archival locations.
- replicationInfos: list of RscSnapshotLocationRetentionInfos
  - List of snapshot retention information objects for the replicated locations.
- localInfo: RscSnapshotLocationRetentionInfo
  - Snapshot retention information object on the local location.
