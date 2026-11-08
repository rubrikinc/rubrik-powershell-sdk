### HpeVmeVirtualMachineDetails
Details of an HPE Virtual Machine Essentials virtual machine.

- hpeVmeVmId: System.String
  - HPE Virtual Machine Essentials virtual machine ID.
- hpeVmeHostId: System.String
  - HPE Virtual Machine Essentials host ID.
- snapshotConsistencyMandate: System.String
  - Snapshot consistency mandate configured for the HPE Virtual Machine
Essentials virtual machine: Automatic, CrashConsistent or
ApplicationConsistent. Null when no mandate is configured, which Rubrik
treats as Automatic.
- agentStatus: System.String
  - Connection status of the Rubrik Backup Service (RBS) agent on the HPE
Virtual Machine Essentials virtual machine: Connected, Disconnected,
Unregistered, SecondaryCluster or Unknown. Null when CDM has not reported
a status.
