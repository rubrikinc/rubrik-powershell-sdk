### DuplicatedVm
Duplicated vSphere virtual machine.

- fid: System.String
  - FID of the virtual machine.
- cluster: Cluster
  - The Rubrik cluster for this virtual machine.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The snapshot distribution of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- reportWorkload: Snappable
  - Specifies statistics, such as capacity, for the protected objects.
- allTags: list of AssignedRscTags
  - RSC tags assigned to this virtual machine.
