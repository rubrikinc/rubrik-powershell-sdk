### ThreatMonitoringMatchedObject
Details about the scanned object.

- filesMatched: System.Int64
  - Number of files matched to threat in object.
- lastDetection: DateTime
  - Date of the last snapshot with a match.
- matchType: list of IndicatorOfCompromiseKinds
  - Type of threat match.
- objectName: System.String
  - The scanned object name.
- cluster: Cluster
  - The cluster of the scan.
