### RansomwareResult
Ransomware Investigation report from lambda service.

- id: System.String
  - The database ID of the ransomware result.
- clusterUuid: System.String
  - The cluster ID of the object.
- workloadId: System.String
  - The internal ID of the object.
- snapshotId: System.String
  - The internal ID of the snapshot.
- snapshotFid: System.String
  - The internal fid of the snapshot.
- snapshotData: DateTime
  - The date of the snapshot.
- encryptionProbability: System.Single
  - The probability of the snapshot being encrypted.
- isEncrypted: System.Boolean
  - Indicates whether the snapshot is encrypted.
- managedId: System.String
  - The internal managed ID of the object.
