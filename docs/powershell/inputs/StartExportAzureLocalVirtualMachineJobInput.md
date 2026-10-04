### StartExportAzureLocalVirtualMachineJobInput
Configuration for exporting an Azure Local Arc virtual machine snapshot into Azure.

- snapshotId: System.String
  - RSC object ID of the source Arc virtual machine snapshot to export.
- hypervClusterId: System.String
  - RSC object ID of the destination Azure Local cluster. Identifies where the virtual
machine is exported to; its subscription, region, and custom location are derived
from the cluster.
- resourceGroup: System.String
  - Destination resource group for the exported virtual machine.
- vmName: System.String
  - Name of the exported ARM virtual machine.
- processors: System.Int32
  - Number of virtual CPUs for the exported virtual machine.
- memoryMb: System.Int64
  - Memory in MB for the exported virtual machine.
- shouldRemoveAllNetworkDevices: System.Boolean
  - If true, the exported virtual machine is created with no NICs. When set,
nicConfigs must be empty.
- nicConfigs: list of AzureLocalNicConfigInputs
  - Network mapping for each NIC on the source virtual machine, in the same order as
the network adapters reported for that virtual machine.
