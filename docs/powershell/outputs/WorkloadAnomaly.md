### WorkloadAnomaly
A workload that has a snapshot or children with anomalous activity.

- workloadFid: System.String
  - The FID of the workload.
- workloadId: System.String
  - The Rubrik CDM ID of the workload.
- workloadName: System.String
  - The name of the workload.
- anomalousSnapshotFid: System.String
  - The FID of the snapshot which was determined to have anomalous activity.
- anomalousSnapshotId: System.String
  - The Rubrik cluster ID of the snapshot determined to have anomalous activity.
- createdFileCount: System.Int64
  - The number of files created within the snapshot.
- deletedFileCount: System.Int64
  - The number of files deleted within the snapshot.
- modifiedFileCount: System.Int64
  - The number of files modified within the snapshot.
- suspiciousFileCount: System.Int64
  - The number of suspicious files within the snapshot.
- encryption: EncryptionLevel
  - The level of encryption detected within the snapshot.
- anomalousChildren: list of WorkloadAnomalys
  - A list of children belonging to the workload. These children were also
 determined to have snapshots with anomalous activity.
- totalChildren: System.Int64
  - The total number of children belong to the workload, regardless
 of whether or not they have snapshots containing anomalous activity.
- anomalyInfo: AnomalyInfo
  - Represents the information about strains that cause anomalies.
- previousSnapshotFid: System.String
  - The FID of the snapshot taken before the snapshot that was determined
 to have anomalous activity.
- anomalyType: AnomalyType
  - Type of the anomaly detected.
- detectionTime: DateTime
  - Time when the anomaly was detected.
- anomalyId: System.String
  - Identifies the anomaly for a given workload.
- resolutionStatus: ResolutionStatus
  - The resolution status of the anomaly.
- objectType: HierarchyObjectTypeEnum
  - The object type of the workload.
- anomalousSnapshotDate: DateTime
  - The creation date of the snapshot determined to have anomalous activity.
- cluster: Cluster
  - The Rubrik cluster associated with the workload.
- location: SnappableLocationType
  - The location of the workload.
- previousPolicyObj: PolicyObj
  - The Data Discovery results of the snapshot before the occurrence of the anomaly in the workload.
- severity: ActivitySeverityEnum
  - Severity of the anomaly event.
