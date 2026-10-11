### SecurityFeaturesStatus
Security notification feature state for one object.

- isMutedForThreatMonitoring: System.Boolean
  - True if this object's leaf workload is muted for Threat Monitoring
notifications.
- isMutedForAnomalyDetection: System.Boolean
  - True if this object's leaf workload is muted for Anomaly Detection
notifications.
- isThreatMonitoringFeatureEnabled: System.Boolean
  - True if Threat Monitoring is configured on for the entity that owns
this object -- its CDM cluster, Cloud Direct cluster, Active
Directory cluster, cloud-native root, or Microsoft 365 organization.
Distinct from mute: enablement is an entity-level setting, mute is
per object. For CDM and Active Directory clusters this reports the
control plane's record of the setting pushed to the cluster, which
enforces scanning itself.
- isAnomalyDetectionFeatureEnabled: System.Boolean
  - True if Anomaly Detection is configured on for the entity that owns
this object. Always true for CDM-cluster-backed objects, since no
per-entity enablement row exists for that type and cluster license
state is not consulted.
