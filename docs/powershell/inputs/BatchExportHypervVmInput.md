### BatchExportHypervVmInput
Input for exporting a batch of Hyper-V virtual machines.

- config: HypervBatchExportSnapshotJobConfigInput
  - Required. An array of configuration objects. Each object includes an identifier for the virtual machine, an identifier for the snapshot of the virtual machine, and the configuration of the exported virtual machine snapshot.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
