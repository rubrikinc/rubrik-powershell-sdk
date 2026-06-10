### AzureSubscriptionThreatAnalyticsEnablement
Azure subscriptions on which Threat Monitoring can be enabled.

- id: System.String
  - Azure subscription ID.
- subscriptionName: System.String
  - Azure subscription name.
- threatMonitoringEnabled: System.Boolean
  - Indicates whether Threat Monitoring is enabled.
- dataThreatAnalyticsEnabled: System.Boolean
  - Indicates whether Data Threat Analytics is enabled.
- isHealthy: System.Boolean
  - Indicates whether the Azure subscription is healthy.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension.
