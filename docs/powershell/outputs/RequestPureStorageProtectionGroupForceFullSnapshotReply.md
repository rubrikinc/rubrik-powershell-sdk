### RequestPureStorageProtectionGroupForceFullSnapshotReply
Response for requesting a forced full snapshot of a Pure Storage protection group.

- id: System.String
  - Required. Supported in v9.6+
ID of the Pure Storage protection group.
- volumeInfos: list of PureStorageVolumeForceFullInfos
  - List of volumes that have requested a forced full snapshot.
