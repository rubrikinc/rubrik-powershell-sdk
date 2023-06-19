### VsphereVmBatchExportV3Input
Supported in Rubrik CDM version 9.0 and later.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- config: BatchExportSnapshotJobConfigV3Input
  - Required. An array of configuration objects. Each object includes an identifier for the virtual machine, an identifier for the snapshot of the virtual machine, and the configuration for the export job and exported virtual machine.
