### AwsAccountThreatAnalyticsEnablement
AWS accounts on which Threat Monitoring can be enabled.

- id: System.String
  - AWS account ID.
- accountName: System.String
  - AWS account name.
- threatMonitoringEnabled: System.Boolean
  - Indicates whether Threat Monitoring is enabled.
- dataThreatAnalyticsEnabled: System.Boolean
  - Indicates whether Data Threat Analytics is enabled.
- isHealthy: System.Boolean
  - Indicates whether the AWS account is healthy.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension.
- isYaraProcessingEnabled: System.Boolean
  - Indicates whether YARA-based threat monitoring is enabled.
- isSmartScanningEnabled: System.Boolean
  - Indicates whether extended file scan coverage is enabled.
- serviceType: AwsCloudAccountServiceType
  - The service classification of the AWS account: Backup as a Service (BaaS)
or standard (non-BaaS).
