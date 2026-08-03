### ThreatHuntBaseConfigInputType
Base config for a threat hunt.

- threatHuntType: ThreatHuntType
  - Threat hunt type.
- name: System.String
  - Name of the threat hunt.
- notes: System.String
  - Notes to describe this threat hunt.
- ioc: IocInputType
  - IOC input of threat hunt. Can be either the list of IOCs or a provider ID.
- snapshotScanLimit: ScanLimitInputType
  - Scan scope of each object with respect to its snapshots.
- fileScanCriteria: HuntScanFileCriteriaInputType
  - File criteria for scan of objects.
- maxMatchesPerSnapshot: System.Int32
  - Indicator Of Compromise within a snapshot terminates once this number
of matches have been detected.
- shouldIncludeArchive: System.Boolean
  - Whether to include archive-tier data when scanning object-store
snapshots. When true, archived data is rehydrated on read. Only applies
to object-store workloads (AWS S3 / Azure Blob); ignored for other
workloads.
