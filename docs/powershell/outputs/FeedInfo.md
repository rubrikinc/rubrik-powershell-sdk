### FeedInfo
Information about the feed.

- providerInfo: ProviderInfo
  - Provider specific information.
- addedBy: System.String
  - User who added the feed.
- feedStats: FeedSummaryStats
  - Statistics about the hash and YARA entries in the feed.
- lastUpdatedTime: DateTime
  - Last updated time of the feed.
- description: System.String
  - Description of the feed.
- feedStatus: FeedStatus
  - Status of the feed.
- autoQuarantineMetadata: AutoQuarantineMetadataType
  - Metadata for auto quarantine.
- providerConfig: ThreatIntelProviderConfigType
  - Configuration specific to the Threat Intel provider (for example, TAXII
server URLs and collection IDs). Populated only for providers requiring
non-credential configuration. Credentials are never returned here.
