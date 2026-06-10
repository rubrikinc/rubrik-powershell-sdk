### CreateOnDemandNutanixBackupInput
Input for creating an on-demand Nutanix backup.

- config: BaseOnDemandSnapshotConfigInput
  - Configuration for the on-demand backup.
- id: System.String
  - Required. v5.0-v5.3: ID of the VM
v6.0+: ID of the Nutanix virtual machine.
- userNote: System.String
  - User note to associate with audits.
