### AggregateSnapshotLocationDetail
Details of all the locations where the snapshot is present.

- localInfo: SnapshotLocationDetail
  - Information of the local cluster if the snapshot is present locally.
- archivalInfos: list of SnapshotLocationDetails
  - Location information of all the archival locations where snapshot is present.
- replicationInfos: list of SnapshotLocationDetails
  - Location information of all the replication locations where snapshot is present.
- rehydratedInfo: SnapshotLocationDetail
  - Rehydrated location if the snapshot was restored from archive onto the cluster.
Populated alongside local_info when both a plain cluster copy and a rehydrated
copy exist for the same snapshot.
