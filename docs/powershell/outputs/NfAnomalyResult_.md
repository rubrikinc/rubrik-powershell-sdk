### NfAnomalyResult
Non-filesystem Anomaly analysis report from lambda service.

- anomalyId: System.String
  - Unique ID for the anomaly.
- workloadFid: System.String
  - The internal FID of the object.
- workloadName: System.String
  - The name of the object.
- detectionTime: DateTime
  - The time at which the anomaly was detected.
- objectType: ObjectTypeEnum
  - The type of the object.
- isAnomaly: System.Boolean
  - Specifies whether the snapshot is anomalous.
- cluster: Cluster
  - The Rubrik cluster of the object.
- location: System.String
  - The location of the object.
