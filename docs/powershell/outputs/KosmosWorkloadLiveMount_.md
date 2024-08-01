### KosmosWorkloadLiveMount
Kosmos Workload Live Mounts.

- id: System.String
  - The Id of the live mount.
- hostMountPath: System.String
  - Describes the mount path in the host machine.
- subnetMask: System.String
  - Describes the subnet configuration of the live mount if any.
- mountCreateTime: DateTime
  - Describes the creation time of the live mount.
- mountedHost: PhysicalHost
  - The Mounted host object.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the live mount.
- workloadId: System.String
  - The Id of respective Kosmos Workload.
- workloadName: System.String
  - Describes the Name of respective Kosmos Workload.
- cluster: Cluster
  - Cluster of the live mount.
