### IrisdbInstanceAppMetadata
IRIS DB instance workload related app metadata for a snapshot.

- stats: KosmosDataSnapshotStats
  - The statistics of the IRIS DB instance snapshot.
- snapshotType: IrisdbSnapshotType
  - Type of the IRIS DB data snapshot. Unspecified until CDM resolves it.
- mountPaths: list of System.Strings
  - Mount paths across all volumes of the snapshot.
- volumes: list of IrisdbSnapshotVolumeInfos
  - Storage volumes of the IRIS DB instance captured in the snapshot.
- instanceVersion: System.String
  - IRIS software version at snapshot time. Absent when the agent could not
read the instance version.
