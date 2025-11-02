### ExportSnapshotToStandaloneHostRequestInput
Supported in v5.0+

- datastoreName: System.String
  - Required. Supported in v5.0+ Name of the datastore to assign to the exported virtual machine.
- hostIpAddress: System.String
  - Required. Supported in v5.0+
The IP address of the standalone ESXi host.
- hostPassword: System.String
  - Required. The admin password of the standalone ESXi host.
- hostUsername: System.String
  - Required. The admin username of the standalone ESXi host.
- mountExportSnapshotJobCommonOptions: MountExportSnapshotJobCommonOptionsInput
  - Common options for virtual machine mount.
