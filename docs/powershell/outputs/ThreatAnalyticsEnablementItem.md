### ThreatAnalyticsEnablementItem
Threat Analytics Enablement Item Type.

- id: System.String
  - Item Id.
- name: System.String
  - Item name.
- dataThreatAnalyticsEnabled: System.Boolean
  - Indicates whether Data Threat Analytics is enabled.
- threatMonitoringEnabled: System.Boolean
  - Indicates whether Threat Monitoring is enabled.
- isHealthy: System.Boolean
  - Indicates whether item is healthy.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension.
Cloud workloads only; always false for M365 and Cloud Direct.
