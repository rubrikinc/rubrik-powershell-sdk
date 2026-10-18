### VsphereMount
Mount of vSphere virtual machine.

- id: System.String
  - RSC ID of the Live Mount.
- cdmId: System.String
  - ID of the Live Mount on the Rubrik cluster.
- mountRequestId: System.String
  - ID of the async request that created the Live Mount.
- unmountRequestId: System.String
  - ID of the async request that removes the Live Mount.
- isReady: System.Boolean
  - Specifies whether the mounted virtual machine is ready.
- clusterName: System.String
  - Name of the Rubrik cluster hosting the Live Mount.
- status: VsphereMountStatus
  - Status of the Live Mount.
- authorizedOperations: AuthorizedOperations
  - Operations the caller is authorized to perform on the Live Mount.
- attachingDiskCount: System.Int32
  - Flattened from the CDM mount spec.
- hasAttachingDisk: System.Boolean
  - Specifies whether the Live Mount attaches disks to an existing virtual
machine.
- migrateDatastoreRequestId: System.String
  - ID of the async request that migrates the Live Mount to another
datastore.
- mountTimestamp: DateTime
  - Time of the Live Mount, as recorded in the CDM mount spec.
- newVmName: System.String
  - Name of the virtual machine created by the Live Mount.
- cluster: Cluster
  - Cluster hosting this mount.
- host: VsphereHost
- newVm: VsphereVm
- sourceSnapshot: CdmSnapshot
- sourceVm: VsphereVm
