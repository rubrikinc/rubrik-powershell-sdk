### VappSnapshotExportOptionsInput
Retrieve vApp snapshot export options.

- exportMode: GetVappSnapshotExportOptionsRequestExportMode
  - Required. Export mode types enum.
- snapshotId: System.String
  - Required. ID assigned to the vApp snapshot object.
- targetOrgVdcId: System.String
  - Optional. ID assigned to a target organization vDC object, when the export is into an existing vDC.
- targetVappId: System.String
  - Optional. ID assigned to the target vApp object, when the export is into an existing vApp.
