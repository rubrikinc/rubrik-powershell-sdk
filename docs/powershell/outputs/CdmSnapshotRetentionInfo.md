### CdmSnapshotRetentionInfo
Snapshot retention information.

- localInfo: CdmSnapshotLocationRetentionInfo
  - Snapshot retention information on the local cluster.
- archivalInfos: list of CdmSnapshotLocationRetentionInfos
  - List of snapshot retention information objects for the archival locations.
- replicationInfos: list of CdmSnapshotLocationRetentionInfos
  - List of snapshot retention information objects for the replicated locations.
- isCustomRetentionApplied: System.Boolean
  - Specifies whether custom retention is applied.
