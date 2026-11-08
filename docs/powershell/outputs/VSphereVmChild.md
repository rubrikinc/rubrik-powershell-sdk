### VSphereVmChild


- fid: System.String
- bootPriority: System.Int32
- snappableType: ObjectTypeEnum
- lastRecoveryPoint: System.Int64
  - Last recovery point.
- snappable: VsphereVm
  - The child VMware object.
- localRpoLagInfo: RpoLagInfo
  - local RPO lag information
- remoteRpoLagInfo: RpoLagInfo
  - remote RPO lag information
- resourceSpec: VmwareResourceSpec
  - Resource specification of the child object.
- recoverySpec: RecoverySpec
  - Recovery specification of the child object.
- failoverInstance: VsphereBlueprintChildFailoverInstance
  - Failover instance of child object.
- recoveryInfo: ChildVmRecoveryInfo
  - The recovery info of the child virtual machine.
