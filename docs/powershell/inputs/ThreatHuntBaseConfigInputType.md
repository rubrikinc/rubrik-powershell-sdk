### ThreatHuntBaseConfigInputType
Base config for a threat hunt.

- notes: System.String
  - Notes to describe this threat hunt.
- threatHuntType: ThreatHuntType
  - Threat hunt type.
- ioc: IocInputType
  - IOC input of threat hunt. Can be either the list of IOCs or a provider ID.
- snapshotScanLimit: ScanLimitInputType
  - Scan scope of each object with respect to its snapshots.
- fileScanCriteria: HuntScanFileCriteriaInputType
  - File criteria for scan of objects.
- name: System.String
  - Name of the threat hunt.
- maxMatchesPerSnapshot: System.Int32
  - Indicator Of Compromise within a snapshot terminates once this number
of matches have been detected.
