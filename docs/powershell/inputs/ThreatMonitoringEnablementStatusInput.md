### ThreatMonitoringEnablementStatusInput
Threat Monitoring enablement status.

- entityType: ThreatMonitoringEnablementEntity
  - The type of entity for which threat monitoring is being enabled.
- entityId: System.String
  - The ID of entity being enabled.
- enabled: System.Boolean
  - Specifies whether to enable Threat Monitoring or not.
- isYaraProcessingEnabled: System.Boolean
  - Indicates whether YARA-based threat monitoring is enabled.
- isSmartScanningEnabled: System.Boolean
  - Indicates whether extended file scan coverage is enabled. Supported for
cloud-native roots and Rubrik clusters only.
