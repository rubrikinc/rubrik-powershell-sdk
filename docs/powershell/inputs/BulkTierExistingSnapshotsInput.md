### BulkTierExistingSnapshotsInput
Input to initiate bulk tiering of existing archived snapshots.

- objectTierInfo: BulkTierSnapshotsConfigInput
  - Required. A list of object IDs to tier. Optionally specifies a location ID.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
