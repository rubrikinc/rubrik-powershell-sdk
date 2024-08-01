### SnapMirrorCloudRestoreParametersInput
Supported in v7.0+
  v7.0-v8.0: 
  v8.1+: Input to restore files from SnapMirror Cloud snapshot.

- ignoreErrors: System.Boolean
  - Supported in v7.0+
      Optional. A Boolean that specifies whether to ignore errors during the restore operation. By default, this value is false.
- netAppAggregateName: System.String
  - Supported in v7.0+
      The name of the aggregate on the NetApp system under which to create the new volume.
- targetNasNamespaceId: System.String
  - Supported in v7.0+
      The Rubrik ID of the NAS namespace on which to create the new volume to which the data should be exported.
- targetNasSystemId: System.String
  - Supported in v7.0+
      The Rubrik ID of the NAS system on which to create the new volume to which the data should be exported.
- targetNasVolumeId: System.String
  - Supported in v7.0+
      The Rubrik ID of the NAS volume to which the data should be exported.
- targetNasVolumeName: System.String
  - Supported in v7.0+
      The name of the new volume to create to which the data should be exported.
- isVolumeRestore: System.Boolean
  - Required. Supported in v7.0+
      A Boolean that specifies whether the restore operation is for the entire volume.
- restorePathPairs: list of SnapMirrorCloudRestorePathPairInputs
  - Supported in v7.0+
      The path relative to the root of the NAS share of the source file. If the restore operation is not using the original source path, also includes the new destination path.
