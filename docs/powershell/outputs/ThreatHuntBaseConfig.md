### ThreatHuntBaseConfig
Base config for a threat hunt.

- notes: System.String
  - Notes to describe this threat hunt.
- threatHuntType: ThreatHuntType
  - Threat hunt type.
- ioc: Ioc
  - Threat hunt IOC input.
- snapshotScanLimit: HuntScanSnapshotLimit
  - Threat hunt snapshot scan limit.
- fileScanCriteria: HuntScanFileCriteria
  - Threat hunt file scan criteria.
- name: System.String
  - Name of the threat hunt.
- maxMatchesPerSnapshot: System.Int32
  - Maximum number of matches per shapshot, per IOC.
