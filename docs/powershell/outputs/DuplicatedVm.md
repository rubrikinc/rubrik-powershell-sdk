### DuplicatedVm
A vSphere virtual machine that is a duplicate of an active machine (e.g.
after vCenter migration or a stale snapshot).

- fid: System.String
  - The ID of the duplicated virtual machine.
- cluster: Cluster
  - The Rubrik cluster for this virtual machine.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- snapshotDistribution: SnapshotDistribution
  - The snapshot distribution of the hierarchy object.
- reportWorkload: Snappable
  - Specifies statistics, such as capacity, for the protected objects.
- allTags: list of AssignedRscTags
  - RSC tags assigned to this virtual machine.
