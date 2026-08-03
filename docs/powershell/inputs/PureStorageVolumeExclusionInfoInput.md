### PureStorageVolumeExclusionInfoInput
Volume ID paired with its desired exclusion status for a Pure Storage protection group.

- volumeId: System.String
  - Required. Supported in v9.6+
ID of the Pure Storage volume.
- isExcludedFromSnapshots: System.Boolean
  - Required. Supported in v9.6+
If true, exclude this volume from snapshot processing for this protection group. If false, include it.
