### BaseSnapshotSummary
Supported in v5.0+

- archivalLocationIds: list of System.Strings
  - Supported in v5.0+
- cloudState: System.Int64
  - Supported in v5.0+
  v5.0-v5.3: Integer value that represents the archival state of a snapshot. 0 means the snapshot is not archived. 2 means the snapshot is archived. 3 means the snapshot is downloaded from the archival location. 4 means the snapshot is in the process of being downloaded from the archival location. 6 means the snapshot is stored locally and at the archival location.
  v6.0-v7.0: Integer value that represents the archival state of a snapshot. 0 means the snapshot is not archived. 2 means the snapshot is archived. 3 means the snapshot is downloaded from the archival location. 4 means the snapshot is in the process of being downloaded from the archival location. 6 means the snapshot is stored locally and at the archival location.
  
  v8.0+: Integer value that represents the archival state of a snapshot. 0 means the snapshot is not archived to any archival location. 2 means the snapshot is archived to any archival location. 3 means the snapshot is downloaded from the archival location. 4 means the snapshot is in the process of being downloaded from the archival location. 6 means the snapshot is stored locally and at least on one of the archival locations.
- consistencyLevel: System.String
  - Supported in v5.0+
- date: DateTime
  - Required. Supported in v5.0+
- expirationDate: DateTime
  - Supported in v5.0+
- id: System.String
  - Required. Supported in v5.0+
- indexState: System.Int64
  - Supported in v5.0+
  Integer value representing the state of the indexing job for a snapshot. 0 means that the indexing has not begun or is in progress. 1 means indexing completed successfully. 2 means that the indexer failed to process this snapshot.
- isOnDemandSnapshot: System.Boolean
  - Required. Supported in v5.0+
- replicationLocationIds: list of System.Strings
  - Required. Supported in v5.0+
- slaId: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1:
  v5.2+: (Deprecated) For a policy based snapshot this parameter contains the ID of the SLA Domain currently assigned to the data source of that snapshot. For an on demand snapshot this field corresponds to the SLA Domain that was assigned when the snapshot was taken. A data source, and individual snapshots, can be reassigned to a different SLA Domain, or the SLA Domain can be modified. In any of these cases this parameter can contain a stale and incorrect value. To view retention information for this snapshot, use snapshotRetentionInfo instead.
- slaName: System.String
  - Required. Supported in v5.0+
  v5.0-v5.1:
  v5.2+: (Deprecated) For a policy based snapshot this parameter contains the name of the SLA Domain currently assigned to the data source of that snapshot. For an on demand snapshot this field corresponds to the SLA Domain that was assigned when the snapshot was taken. A data source, and individual snapshots, can be reassigned to a different SLA Domain, or the SLA Domain can be modified. In any of these cases this parameter can contain a stale and incorrect value. To view retention information for this snapshot, use snapshotRetentionInfo instead.
- sourceObjectType: System.String
  - Supported in v5.0+
- isRetainedByRetentionLockSla: System.Boolean
  - Supported in v5.1+
  v5.1: A Boolean that indicates whether the snapshot is being retained under a Retention Lock SLA Domain. When this value is 'true,' the snapshot is being retained under a Retention Lock SLA Domain.
  v5.2+: A Boolean that indicates whether the snapshot is being retained under a Retention Lock SLA Domain. When this value is 'true', the snapshot is being retained under a Retention Lock SLA Domain.
- isCustomRetentionApplied: System.Boolean
  - Supported in v5.2+
  A Boolean that indicates whether or not custom retention is applied to the snapshot.
- isPlacedOnLegalHold: System.Boolean
  - Supported in v5.2+
  A Boolean that indicates whether the snapshot is placed on Legal Hold. When this value is 'true', the snapshot is placed on Legal Hold.
- parentSnapshotId: System.String
  - Supported in v5.2+
  ID of the parent snapshot if the current snapshot is a child snapshot. Child snapshots are snapshots of objects that are part of an app, either a vCloud Director vApp or an AppBlueprint. Snapshots of the app are parent snapshots.
- cloudStorageTier: SnapshotCloudStorageTier
  - Supported in v5.1+
- snapshotRetentionInfo: SnapshotRetentionInfo
  - Supported in v5.2+
  Snapshot retention related information for local, archival and replication locations.
- cloudStorageTiers: list of PerLocationCloudStorageTiers
  - Supported in v8.0+
  A list of those archival location entries where cloudStorageTier is applicable.
