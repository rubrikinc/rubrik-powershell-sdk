### VsphereVmBatchExportInput
Input for batch export snapshots for vSphere.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- config: BatchExportSnapshotJobConfigInput
  - Required. An array of configuration objects. Each object includes an identifier for the virtual machine, an identifier for the snapshot of the virtual machine, and the configuration for the exported virtual machine snapshot.
