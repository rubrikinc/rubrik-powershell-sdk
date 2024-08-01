### NutanixVmDetail
Supported in v5.0+

- excludedDiskIds: list of System.Strings
  - Required. Supported in v5.0+
  A list of virtual disk IDs to exclude from the backup for this virtual machine.
- isAgentRegistered: System.Boolean
  - Required. Supported in v5.0+
  Returns whether the Rubrik connector is installed and service is registered.
- isPaused: System.Boolean
  - Required. Supported in v5.0+
  Whether backup/archival/replication is paused for this System Volume.
- virtualDisks: list of NutanixVirtualDiskSummarys
  - Supported in v5.2+
  Information of all the virtual disks for this virtual machine.
- nutanixVmPatch: NutanixVmPatch
  - 
- nutanixVmSummary: NutanixVmSummary
  - 
- blackoutWindowResponseInfo: BlackoutWindowResponseInfo
  - 
