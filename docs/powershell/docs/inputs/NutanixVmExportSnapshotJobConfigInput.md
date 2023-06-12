### NutanixVmExportSnapshotJobConfigInput
Supported in v5.0+

- nutanixClusterId: System.String
  - Supported in v5.0+
      v5.0-v6.0: The ID of the Nutanix cluster to export to. If not specified, we will default to the VM's cluster.
      v7.0+: The ID of the Nutanix cluster for export. Defaults to the virtual machine's cluster if unspecified.
- powerOn: System.Boolean
  - Indicates if the virtual machine is started after an export operation.
- removeNetworkDevices: System.Boolean
  - Supported in v5.0+
      v5.0-v6.0: Determines whether to remove the network interfaces from the exported virtual machine. Set to 'true' to remove all network interfaces. The default value is 'false'. If 'false' the export job will attempt to add nics that were both present at snapshot time and connected to networks that are still present on the target cluster.
      v7.0+: Determines whether to remove the network interfaces from the exported virtual machine. Set to 'true' to remove all network interfaces. The default value is 'false'. If set to 'false', the export job attempts to add NICs that were present at the time of the snapshot and were connected to networks that are still present on the target cluster.
- vmName: System.String
  - Name of the new virtual machine for export.
- keepMacAddresses: System.Boolean
  - Supported in v8.1+
      Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. Set to 'true' to assign the original MAC addresses to the new virtual machine if nicNetworkUuids is provided. Set to 'false' to assign new MAC addresses.The default is 'false'. When removeNetworkDevices is set to true, this property is ignored.
- nicNetworkUuids: list of System.Strings
  - Supported in v8.1+
      The IDs of the Nutanix networks used to create NICs on the exported virtual machine.
- containerNaturalId: System.String
  - Required. Supported in v5.0+
      v5.0-v6.0: The natural ID of the container that will store the export VM's disks.
      v7.0+: The ID of the storage container that stores the export virtual machine's disks.
