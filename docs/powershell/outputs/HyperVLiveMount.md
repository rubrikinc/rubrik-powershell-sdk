### HyperVLiveMount
HyperV live mount.

- id: System.String
  - Fid of the live mount.
- isVmReady: System.Boolean
  - Describes if the live mount is ready.
- name: System.String
  - Name of the live mount.
- sourceVm: System.String
  - Name of the source virtual machine.
- mountSpec: System.String
  - Specification of the live mount in JSON string.
- serverFid: System.String
  - ID of the HyperV server.
- sourceVmFid: System.String
  - ID of the source virtual machine..
- mountedVmFid: System.String
  - ID of the mounted virtual machine..
- serverName: System.String
  - Host name of the server where Hyper-V virtual machine is live mounted.
- mountTime: DateTime
  - Time when the snapshot was mounted.
- isDiskLevelMount: System.Boolean
  - Describes if the mount is a disk mount.
- targetVmFid: System.String
  - ID of the target virtual machine for disk mount.
- targetVm: System.String
  - Name of the target virtual machine for disk mount.
- attachedDiskCount: System.Int32
  - Number of disks attached to the target virtual machine.
- mountedVmStatus: HypervMountedVmStatusType
  - Power status of the live-mounted Hyper-V virtual machine.
+ Typed replacement for the legacy string vm_status = 5.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the live mount.
- cluster: Cluster
  - Cluster of the live mount.
