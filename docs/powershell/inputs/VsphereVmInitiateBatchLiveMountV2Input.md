### VsphereVmInitiateBatchLiveMountV2Input
Input for live mounting multiple vSphere snapshots.

- config: BatchMountSnapshotJobConfigV2Input
  - Required. Configuration object containing an array of virtual machine IDs, providing a way to indicate the selected snapshot and the mount configurations.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
