### IocFeedEntry
Information about the IOC.

- intelId: System.String
  - Unique identifier of the intel.
- providerMalwareId: System.String
  - ID of the malware from the provider.
- providerIocId: System.String
  - ID of the IOC from the provider.
- iocType: ThreatFeedType
  - Type of the IOC.
- providerInfo: ProviderInfo
  - Provider specific info.
- lastUpdatedTime: DateTime
  - Last updated time of the IOC from the provider.
- hashInfo: HashInfo
  - Hash details if the IOC type is hash.
- yaraInfo: YaraInfo
  - YARA rule details if the IOC type is YARA.
- threatFamily: System.String
  - The Threat Family associated with the IOC.
- author: System.String
  - IOC author.
- disabledInfo: DisabledInfo
  - Only set if the IOC is deactivated by a user.
- iocStatus: FeedEntryStatus
  - Status of the feed entry.
