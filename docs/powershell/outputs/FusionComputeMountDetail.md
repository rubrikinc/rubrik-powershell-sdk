### FusionComputeMountDetail
Details of a FusionCompute live mount.

- fid: System.String
  - FID of the live mount.
- name: System.String
  - Name of the live mount.
- snapshotFid: System.String
  - Snapshot FID of the FusionCompute mount.
- sourceVmFid: System.String
  - Source virtual machine FID of the FusionCompute mount.
- mountTimestamp: System.String
  - Timestamp when the mount was created (human-readable string).
- isReady: System.Boolean
  - Describes if the live mount is ready.
- cdmId: System.String
  - Rubrik cluster ID of the live mount.
- vmStatus: FusionComputeVmStatus
  - Status of the live mount.
- sourceVmId: System.String
  - ID of the source virtual machine.
- sourceVmName: System.String
  - Name of the source virtual machine.
- mountedVmId: System.String
  - ID of the mounted virtual machine.
- mountedVmName: System.String
  - Name of the mounted virtual machine.
- hostUrn: System.String
  - Target host URN.
- siteUrn: System.String
  - Target site URN.
- clusterUrn: System.String
  - Target cluster URN.
- datastoreName: System.String
  - Datastore name.
- nasIp: System.String
  - NAS IP address.
- newVmUrn: System.String
  - Identifier of the newly created virtual machine.
- snapshotDate: DateTime
  - Date of the source snapshot.
- hostName: System.String
  - Display name for the mount target. Holds the target host name when
the mount is pinned to a specific host; falls back to the target
cluster name when the mount was scheduled at cluster granularity.
- cluster: Cluster
  - Rubrik cluster of the FusionCompute live mount.
