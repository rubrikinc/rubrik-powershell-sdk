### VmwareVmMountSummaryV1
Supported in v5.0+

- attachingDiskCount: System.Int32
  - Supported in v5.0+
  An integer value that identifies how many disks are attached.
- createDatastoreOnlyMount: System.Boolean
  - Supported in v5.0+
  This boolean value determines whether or not the mount is created as a datastore only. When 'true,' the mount is created with datastore and not the associated virtual machine. When 'false,' the mount is created with both the datastore and the associated virtual machine.
- datastoreName: System.String
  - Supported in v5.0+
  The name of the datastore that contains the mounted VMDK.
- datastoreReady: System.Boolean
  - Supported in v5.0+
  A boolean value that specifies whether the datastore is ready. When 'true,' the datastore is ready. When 'false,' the datastore is not ready.
- hasAttachingDisk: System.Boolean
  - Supported in v5.0+
  A Boolean value that determines whether this job is an attaching disk mount job. When 'true,' this is an attaching disk mount job. When 'false,' this is not an attaching disk mount job.
- hostId: System.String
  - Supported in v5.0+
- id: System.String
  - Required. Supported in v5.0+
- isReady: System.Boolean
  - Required. Supported in v5.0+
- mountRequestId: System.String
  - Supported in v5.0+
- mountTimestamp: DateTime
  - Supported in v5.0+
  Gives the timestamp at which the mount was created.
- mountedVmId: System.String
  - Supported in v5.0+
- snapshotDate: DateTime
  - Required. Supported in v5.0+
- unmountRequestId: System.String
  - Supported in v5.0+
- vmId: System.String
  - Required. Supported in v5.0+
