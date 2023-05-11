### VappExportSnapshotJobConfigInput
Supported in v5.0+

- exportMode: VappExportMode
  - Required. Supported in v5.0+
- networksToRestore: a list of CreateVappNetworkParamsInputs
  - Required. Supported in v5.0+
      Array of vApp networks that are in the specified vApp snapshot and should be set up as part of the export operation. A vApp network that is not included in the array will not be set up in the exported vApp.
- newVappParams: CreateNewVappParamsInput
  - Supported in v5.0+
- shouldPowerOnVappAfterExport: System.Boolean
  - Supported in v5.0+
      Boolean value that indicates whether to power on the exported vApp. Use 'true' to turn the power on for the exported vApp or use 'false' to leave the power off for the exported vApp.
- targetVappId: System.String
  - Supported in v5.0+
      ID assigned to the target vApp object, when the export is into an existing vApp. When the export is not into a target vApp, remove the 'targetVappId' member.
- vmsToExport: a list of VappVmRestoreSpecInputs
  - Required. Supported in v5.0+
      An array containing summary information for the virtual machines included in the vApp export.
