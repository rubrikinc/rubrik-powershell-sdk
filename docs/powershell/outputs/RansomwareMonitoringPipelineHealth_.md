### RansomwareMonitoringPipelineHealth
Specifies the pipeline health metric for Threat Monitoring,Threat Hunt, and Ransomware Investigation.

- anomaliesFound: System.Int64
  - Number of anomalies found.
- threatsFound: System.Int64
  - Number of threats found.
- matchedHunts: System.Int64
  - Number of hunts which had matches.
- activeHunts: System.Int64
  - Number of hunts which are active.
- successfulBackups: System.Int64
  - Number of successful backups.
- failedBackups: System.Int64
  - Number of failed backups.
- threatMonitoringYaraIocStatus: list of ThreatFeedScanStatuss
  - Status of the TM scan for the newly added yara IOCs.
- threatMonitoringHashIocStatus: list of ThreatFeedScanStatuss
  - Status of the TM scan for the newly added hash IOCs.
