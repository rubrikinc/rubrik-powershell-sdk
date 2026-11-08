### AdfrRecoverySpecType
Active Directory Forest Recovery specification.

- appId: System.String
  - ID of the recovery plan.
- snappableId: System.String
  - ID of the workload.
- version: System.Int64
  - Version of the recovery specification.
- userData: System.String
  - Script to run on the recovered domain controller after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- hostWorkloadFid: System.String
  - FID of the host workload (virtual machine).
- hostSnapshotFid: System.String
  - FID of the host snapshot (virtual machine snapshot).
- hostRecoveryPoint: System.Int64
  - Recovery point timestamp for the host (virtual machine).
- vmwareVm: VsphereVmRecoverySpec
  - VMware virtual machine recovery specification for the host.
- addc: AddcRecoverySpec
  - Active Directory Domain Controller recovery configuration.
- recoveryVlanId: System.Int32
  - VLAN ID to use for recovery network configuration.
