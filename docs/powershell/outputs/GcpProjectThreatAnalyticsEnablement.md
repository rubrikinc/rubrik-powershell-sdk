### GcpProjectThreatAnalyticsEnablement
GCP projects on which Threat Monitoring can be enabled.

- id: System.String
  - GCP project ID.
- projectName: System.String
  - GCP project name.
- threatMonitoringEnabled: System.Boolean
  - Indicates whether Threat Monitoring is enabled.
- dataThreatAnalyticsEnabled: System.Boolean
  - Indicates whether Data Threat Analytics is enabled.
- isHealthy: System.Boolean
  - Indicates whether the GCP project is healthy.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension.
- isYaraProcessingEnabled: System.Boolean
  - Indicates whether YARA-based threat monitoring is enabled.
- isSmartScanningEnabled: System.Boolean
  - Indicates whether extended file scan coverage is enabled.
