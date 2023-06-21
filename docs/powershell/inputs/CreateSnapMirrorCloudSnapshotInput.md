### CreateSnapMirrorCloudSnapshotInput
Input to start an on-demand backup of SnapMirror Cloud workload.

- config: BaseOnDemandSnapshotConfigInput
  - Configuration for the on-demand backup.
- id: System.String
  - Required. v7.0-v8.0: ID of the SnapMirror Cloud protected object.
      v8.1+: ID of the SnapMirror Cloud workload.
