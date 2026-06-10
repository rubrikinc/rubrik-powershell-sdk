### EnableThreatMonitoringInput
Request to enable/disable Threat Monitoring for a single entity or a batch of entities.

- status: ThreatMonitoringEnablementStatusInput
  - Entity to point enable/disable.
- rootIds: list of System.Strings
  - List of entity root ids to batch enable/disable.
- isBatchEnabled: System.Boolean
  - Whether to enable or disable the batch of entities.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension. Cloud workloads only.
