### PendingEvaluationResults
Detailed information about workloads passing through the Ransomware Investigation pipeline.

- clusterUuid: System.String
  - Unique UUID of the cluster.
- workloadId: System.String
  - Internally used ID to specify workload.
- workloadName: System.String
  - Workload name.
- workloadType: System.String
  - Type of the workload.
- snapshotId: System.String
  - Internally used ID to specify snapshot.
- snapshotDate: DateTime
  - Date that this snapshot was performed.
- createdAt: DateTime
  - Specifies the date this workload was added in Ransomware Investigation.
- updatedAt: DateTime
  - Specifies the date this workload was last updated in Ransomware Investigation.
- managedId: System.String
  - Internally used ID to manage permissions of this workload.
- isCompleted: System.Boolean
  - Determines whether a result is still pending in the Ransomware Investigation pipeline.
- info: System.String
  - Information about this workload within the Ransomware Investigation pipeline.
