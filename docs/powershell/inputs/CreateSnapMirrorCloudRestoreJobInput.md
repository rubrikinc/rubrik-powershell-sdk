### CreateSnapMirrorCloudRestoreJobInput
Input to restore files from SnapMirror Cloud snapshot.

- id: System.String
  - Required. The ID of the snapshot from which to restore.
- jobConfig: SnapMirrorCloudRestoreParametersInput
  - Required. Configuration for the job to restore files or the volume from a SnapMirrorCloud backup.
