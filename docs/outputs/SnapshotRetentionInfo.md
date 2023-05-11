### SnapshotRetentionInfo
Supported in v5.2+

- archivalInfos: a list of SnapshotLocationRetentionInfos
  - Required. Supported in v5.2+
  List of snapshot retention information on the archival locations.
- cloudNativeLocationInfo: a list of SnapshotLocationRetentionInfos
  - Required. Supported in v5.2+
  Snapshot retention information such as frequency tag and expected expiration time on the cloud native locations.
- localInfo: SnapshotLocationRetentionInfo
  - Supported in v5.2+
  Snapshot retention information on the local cluster.
- replicationInfos: a list of SnapshotLocationRetentionInfos
  - Required. Supported in v5.2+
  List of snapshot retention information on the replicated locations.
