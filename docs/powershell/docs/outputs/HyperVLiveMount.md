### HyperVLiveMount
HyperV live mount.

- isVmReady: System.Boolean
  - Describes if the live mount is ready.
- name: System.String
  - Name of the live mount.
- sourceVm: System.String
  - Name of the source HyperV VM.
- mountSpec: System.String
  - Specification of the live mount in JSON string.
- serverName: System.String
  - Host name of the server where Hyper-V virtual machine is live mounted.
- mountTime: DateTime
  - Time when the snapshot was mounted.
- mountedVmStatus: HypervMountedVmStatusType
  - Power Status of HyperV Live Mount.
- id: System.String
  - Fid of the live mount.
- sourceVmFid: System.String
  - ID of the source virtual machine..
- mountedVmFid: System.String
  - ID of the mounted virtual machine..
- serverFid: System.String
  - ID of the HyperV server.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the live mount.
- cluster: Cluster
  - Cluster of the live mount.
