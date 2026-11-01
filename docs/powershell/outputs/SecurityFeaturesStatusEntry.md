### SecurityFeaturesStatusEntry
The security notification state of one object.

- fid: System.String
  - The Rubrik UUID of the object.
- status: SecurityFeaturesStatus
  - Mute state and entity-level enablement of the object.
- supportedForAnomalyDetection: System.Boolean
  - Whether the object's type supports Anomaly Detection.
- supportedForThreatMonitoring: System.Boolean
  - Whether the object's type supports Threat Monitoring.
