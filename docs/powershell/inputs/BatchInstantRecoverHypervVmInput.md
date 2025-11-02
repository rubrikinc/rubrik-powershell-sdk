### BatchInstantRecoverHypervVmInput
Input for batch recovery of Hyper-V virtual machines.

- config: HypervBatchInstantRecoverSnapshotJobConfigInput
  - Required. An array of configuration objects. Each object includes an identifier for the virtual machine, an identifier for the snapshot of the virtual machine, and the configuration for instant recovery.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
