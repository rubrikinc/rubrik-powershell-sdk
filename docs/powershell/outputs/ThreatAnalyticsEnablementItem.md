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
- awsServiceType: AwsCloudAccountServiceType
  - AWS-only: the service classification (Backup as a Service or standard).
Not applicable for non-AWS items (Azure, GCP, M365, Cloud Direct).
- isYaraProcessingEnabled: System.Boolean
  - Indicates whether YARA-based threat monitoring is enabled. Applies to
cloud-native roots only (AWS, Azure, GCP); always returns false for M365
and Cloud Direct.
