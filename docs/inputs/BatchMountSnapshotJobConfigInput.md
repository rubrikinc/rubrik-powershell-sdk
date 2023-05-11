### BatchMountSnapshotJobConfigInput
Supported in v5.0+

- snapshots: a list of MountSnapshotJobConfigForBatchV1Inputs
  - Required. Supported in v5.0+
      v5.0: Array of virtual machine IDs with snapshots to be live mounted.
      v5.1-v5.3: Array of vm_ids to live mount a snapshot from
      v6.0+: Array of objects containing information about snapshots to mount.
