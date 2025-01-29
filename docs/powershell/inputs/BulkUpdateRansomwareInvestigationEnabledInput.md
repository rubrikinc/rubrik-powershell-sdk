### BulkUpdateRansomwareInvestigationEnabledInput
Request to set Ransomware Investigation enabled or not in bulk.

- entities: list of DataThreatAnalyticsEnablementEntityInfos
  - List of entities for which the Ransomware Investigation status is being updated.
- isRansomwareMonitoringEnabled: System.Boolean
  - The new Ransomware Investigation status.
- clusterId: System.String
  - The ID of the cluster.
