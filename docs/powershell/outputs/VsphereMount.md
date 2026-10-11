### VsphereMount
Mount of vSphere virtual machine.

- id: System.String
- cdmId: System.String
- mountRequestId: System.String
- unmountRequestId: System.String
- isReady: System.Boolean
- clusterName: System.String
- status: VsphereMountStatus
- authorizedOperations: AuthorizedOperations
- attachingDiskCount: System.Int32
  - Flattened from the CDM mount spec.
- hasAttachingDisk: System.Boolean
- migrateDatastoreRequestId: System.String
- mountTimestamp: DateTime
- newVmName: System.String
- cluster: Cluster
  - Cluster hosting this mount.
- host: VsphereHost
- newVm: VsphereVm
- sourceSnapshot: CdmSnapshot
- sourceVm: VsphereVm
