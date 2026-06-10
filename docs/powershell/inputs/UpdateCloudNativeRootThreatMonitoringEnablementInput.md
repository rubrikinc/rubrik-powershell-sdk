### UpdateCloudNativeRootThreatMonitoringEnablementInput
Request to update Threat Monitoring enablement for cloud native roots.

- isEnabled: System.Boolean
  - New status of Threat Monitoring enablement.
- rootIds: list of System.Strings
  - List of cloud native root IDs.
- shouldScanAllFiles: System.Boolean
  - When true, threat monitoring scans all files regardless of extension. Cloud workloads only.
