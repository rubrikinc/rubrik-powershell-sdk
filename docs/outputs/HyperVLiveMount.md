### HyperVLiveMount
HyperV live mount.

- cluster: Cluster
  - Cluster of the live mount.
- id: System.String
  - Fid of the live mount.
- isVmReady: System.Boolean
  - Describes if the live mount is ready.
- mountSpec: System.String
  - Specification of the live mount in JSON string.
- mountTime: DateTime
  - Time when the snapshot was mounted.
- mountedVmFid: System.String
  - ID of the mounted virtual machine..
- mountedVmStatus: HypervMountedVmStatusType
  - Power Status of HyperV Live Mount.
- name: System.String
  - Name of the live mount.
- serverFid: System.String
  - ID of the HyperV server.
- serverName: System.String
  - Host name of the server where Hyper-V virtual machine is live mounted.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the live mount.
- sourceVm: System.String
  - Name of the source HyperV VM.
- sourceVmFid: System.String
  - ID of the source virtual machine..
