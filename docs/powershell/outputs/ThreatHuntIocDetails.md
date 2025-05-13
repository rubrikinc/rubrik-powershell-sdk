### ThreatHuntIocDetails
IOC details for a matched file.

- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- intelFeedName: System.String
  - Name of the intel feed for the IOC.
- threatFamily: System.String
  - Name of the threat family.
- hashRule: HashInfo
  - Description of the hash IOC.
- yaraRule: System.String
  - Description of the YARA IOC.
- filePatternRule: System.String
  - Description of the path IOC.
