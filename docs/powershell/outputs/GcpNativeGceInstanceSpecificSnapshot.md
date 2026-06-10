### GcpNativeGceInstanceSpecificSnapshot
Snapshot information specific to the GCP GCE instance.

- serviceAccountEmail: System.String
  - Email of the service account attached to the GCE instance at the time the snapshot was taken.
- machineType: System.String
  - Machine type of the GCE instance at the time the snapshot was taken.
- networkHostProjectNativeId: System.String
  - Network host project native ID of the GCE instance.
- vpcName: System.String
  - VPC name of the GCE instance.
- subnetName: System.String
  - Subnet name of the GCE instance.
- networkTags: list of System.Strings
  - Network tags of the GCE instance.
- snapshotId: System.String
  - ID of the snapshot.
