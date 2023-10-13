### SnapshotCloudStorageTier
Supported in v5.1+
  v5.1-v5.2: The current cloud storage tier of a snapshot. A snapshot's cloud storage tier determines how the cloud provider will determine storage and retrieval costs, as well as retrieval latency. Accepted values are Hot, Cool, and Cold.
  
  v5.3-v8.1: The current cloud storage tier of a snapshot. A snapshot's cloud storage tier determines how the cloud provider will determine storage and retrieval costs, as well as retrieval latency. Accepted values are Hot, Cool, AzureArchive (with Azure locations), Glacier, and GlacierDeepArchive (for AWS S3 locations). The value Cold has been deprecated in favor of AzureArchive, which is the recommended replacement value.
  
  v9.0+: The current cloud storage tier of a snapshot. A snapshot's cloud storage tier determines how the cloud provider will determine storage and retrieval costs, as well as retrieval latency. Accepted values are Hot (for AWS S3 and Azure), StandardIA, OneZoneIA, GlacierIR, Glacier, and GlacierDeepArchive (for AWS S3), and AzureCool, AzureCold, and AzureArchive (for Azure). The value Cold has been deprecated in favor of AzureArchive, Glacier, and GlacierDeepArchive. The value Cool has been deprecated in favor of StandardIA, OneZoneIA, GlacierIR, AzureCool, and AzureCold.
  

- SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE
- SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COLD
- SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_COOL
- SNAPSHOT_CLOUD_STORAGE_TIER_COLD
- SNAPSHOT_CLOUD_STORAGE_TIER_COOL
- SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER
- SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE
- SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_IR
- SNAPSHOT_CLOUD_STORAGE_TIER_HOT
- SNAPSHOT_CLOUD_STORAGE_TIER_ONE_ZONE_IA
- SNAPSHOT_CLOUD_STORAGE_TIER_STANDARD_IA
