### DeleteSnapMirrorCloudInput
Input for deleting NetApp SnapMirror Cloud workload.

- id: System.String
  - Required. v7.0-v8.0: Provide the ID of a SnapMirror Cloud protected object to delete.
      v8.1+: Provide the ID of a SnapMirror Cloud workload to delete.
- preserveSnapshots: System.Boolean
  - v7.0-v8.0: Flag to indicate whether to preserve snapshots of the SnapMirror Cloud protected object or delete them. The default is to preserve the snapshots.
      v8.1+: Flag to indicate whether to preserve snapshots of the SnapMirror Cloud workload or delete them. The default is to preserve the snapshots.
