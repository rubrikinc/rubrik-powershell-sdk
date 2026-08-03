### AdfrRecoverySpec
Active Directory Forest Recovery specification.
This message combines virtual machine recovery specification with
ADDC-specific recovery configuration.

- version: System.Int64
  - Version of the recovery specification (system-managed).
- hostWorkloadFid: System.String
  - Host workload ID.
- hostSnapshotFid: System.String
  - Host snapshot ID.
- hostRecoveryPoint: System.Int64
  - Host recovery point timestamp.
- addc: AddcRecoverySpec
  - Active Directory Domain Controller recovery configuration.
- recoveryVlanId: System.Int32
  - VLAN ID to use for recovery network configuration.
- hostSpec: AdfrHostSpec
  - The platform-specific host recovery specification.
