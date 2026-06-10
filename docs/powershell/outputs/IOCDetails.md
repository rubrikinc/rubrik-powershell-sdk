### IOCDetails
Details of IOC for a matched file.

- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- intelFeedName: System.String
  - Name of the intel feed for the IOC.
- malwareName: System.String
  - Name of the malware for the IOC.
- iocRuleAuthor: System.String
  - Author of the IOC.
- malwareDescription: System.String
  - Description of the malware for the IOC.
- iocHashHex: System.String
  - Hash of the IOC.
- feedType: FeedType
  - Source type of the intel feed, for example RUBRIK, CROWDSTRIKE, or
TAXII_2_1. Used by clients to gate per-feed actions such as enabling
or disabling IOC.
- iocStatus: FeedEntryStatus
  - Status of the feed entry.
