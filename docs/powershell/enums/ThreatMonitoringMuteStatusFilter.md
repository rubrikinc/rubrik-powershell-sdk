### ThreatMonitoringMuteStatusFilter
Threat Monitoring mute-status filter for threatMonitoringMatchedObjects.
Orion-only -- unrelated to the SECURITY_NOTIFICATION_MUTE_STATUS hierarchy
filter, which covers both Threat Monitoring and Anomaly Detection.

- THREAT_MONITORING_MUTE_STATUS_FILTER_UNSPECIFIED - No mute-status filter applied; matches objects regardless of mute state.
- THREAT_MONITORING_MUTE_STATUS_FILTER_ACTIVE - Matches objects that are not muted for Threat Monitoring.
- THREAT_MONITORING_MUTE_STATUS_FILTER_MUTED - Matches objects that are muted for Threat Monitoring.
