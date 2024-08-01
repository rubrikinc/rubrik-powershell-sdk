### ThreatHuntBaseConfig
Base config for a threat hunt.

- name: System.String
  - Name of the threat hunt.
- notes: System.String
  - Notes to describe this threat hunt.
- maxMatchesPerSnapshot: System.Int32
  - Indicator Of Compromise within a snapshot terminates once this number
 of matches have been detected.
- threatHuntType: ThreatHuntType
  - Threat hunt type.
- ioc: ThreatHuntIocInput
  - Threat hunt IOC input.
- snapshotScanLimit: HuntScanSnapshotLimit
  - Hunt scan snapshot limit.
- fileScanCriteria: HuntScanFileCriteria
  - Hunt scan file criteria.
