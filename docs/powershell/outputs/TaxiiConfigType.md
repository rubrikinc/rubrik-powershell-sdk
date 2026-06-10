### TaxiiConfigType
Configuration for a TAXII 2.1 threat intelligence feed.
Stored internally as a proto-serialized format in the provider_config column.
This field is immutable after creation; to modify these settings, the feed
must be deleted and re-created.

- serverUrl: System.String
  - The TAXII server secure URL including the API root
(e.g., "https://taxii.example.com/api-root").
- collectionIds: list of System.Strings
  - The TAXII collection IDs to pull IOCs from.
- minConfidenceScore: System.Int32
  - Minimum confidence score (0-100) for IOC filtering.
IOCs below this score are discarded during synchronization.
- maxIocAgeDays: System.Int32
  - Maximum age of IOCs in days.
IOCs older than this are discarded during synchronization.
