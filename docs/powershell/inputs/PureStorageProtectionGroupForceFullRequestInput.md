### PureStorageProtectionGroupForceFullRequestInput
Input for requesting a forced full snapshot of a Pure Storage protection group.

- volumeInfos: list of PureStorageVolumeForceFullInfoInputs
  - List of volumes configured for forced full snapshots. An empty list forces full snapshots for all volumes with default deduplication.
