### ThreatHuntBaseConfig
Base config for a threat hunt.

- threatHuntType: ThreatHuntType
  - Threat hunt type.
- name: System.String
  - Name of the threat hunt.
- notes: System.String
  - Notes to describe this threat hunt.
- ioc: Ioc
  - Threat hunt IOC input.
- snapshotScanLimit: HuntScanSnapshotLimit
  - Threat hunt snapshot scan limit.
- fileScanCriteria: HuntScanFileCriteria
  - Threat hunt file scan criteria.
- maxMatchesPerSnapshot: System.Int32
  - Maximum number of matches per shapshot, per IOC.
