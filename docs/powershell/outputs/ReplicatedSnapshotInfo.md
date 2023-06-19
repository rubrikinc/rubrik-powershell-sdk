### ReplicatedSnapshotInfo
Information about Kubernetes Replicated Snapshots.

- snapshotId: System.String
  - ID to uniquely identify the snapshot.
- snappableId: System.String
  - ID of the workload to which the snapshot belongs.
- date: DateTime
  - Time the snapshot was created.
- expirationDate: DateTime
  - Time the snapshot expires.
- associatedCdm: Cluster
  - CDM cluster associated with the snapshot.
