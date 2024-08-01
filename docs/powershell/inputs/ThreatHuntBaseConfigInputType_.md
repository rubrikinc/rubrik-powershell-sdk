### ThreatHuntBaseConfigInputType
Base config for a threat hunt.

- name: System.String
  - Name of the threat hunt.
- notes: System.String
  - Notes to describe this threat hunt.
- maxMatchesPerSnapshot: System.Int32
  - Indicator Of Compromise within a snapshot terminates once this number
 of matches have been detected.
- threatHuntType: ThreatHuntType
- ioc: ThreatHuntIocInputType
  - IOC input of threat hunt. Can be either the list of IOCs or a provider ID.
- snapshotScanLimit: HuntScanSnapshotLimitInputType
  - Scan scope of each object with respect to its snapshots.
- fileScanCriteria: HuntScanFileCriteriaInputType
  - File criteria for scan of objects.
