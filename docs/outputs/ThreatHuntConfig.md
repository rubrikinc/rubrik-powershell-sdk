### ThreatHuntConfig
Config as the input to start a threat hunt.

- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- fileScanCriteria: MalwareScanFileCriteria
  - Criteria to restrict files to scan.
- indicatorsOfCompromise: a list of IndicatorOfCompromises
  - List of IOCs to scan for.
- maxMatchesPerSnapshot: System.Int32
  - Maximum number of matches per shapshot, per IOC.  Scanning for an Indicator Of Compromise within a snapshot will terminate once this many matches have been detected. Defaults to one.
- name: System.String
  - Name of this threat hunt.
- notes: System.String
  - Notes to describe this threat hunt.
- objects: a list of CdmHierarchySnappableNews
  - The objects to be scanned for malware.
- requestedMatchDetails: RequestedMatchDetails
  - Additional information required for files with malware matches.
- shouldTrustFilesystemTimeInfo: System.Boolean
  - Specifies whether features that rely on the accuracy of filesystem metadata, like creation time and modification time of files, are enabled or not. These features include backend optimizations to skip re-scanning files that have not changed across snapshots, as indicated by the unchanged timestamps of files. This flag also gates access to some filters that can be specified in this API. Note that this flag should be used with caution, as relying on file timestamps may make the system vulnerable to adversarial techniques such as timestamp manipulation.
- snapshotScanLimit: MalwareScanSnapshotLimit
  - Limit which snapshots to include in the threat hunt.
