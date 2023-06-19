### SnapshotCloudStorageTier
Supported in v5.1+
  v5.1-v5.2: The current cloud storage tier of a snapshot. A snapshot's cloud storage tier determines how the cloud provider will determine storage and retrieval costs, as well as retrieval latency. Accepted values are Hot, Cool, and Cold.
  
  v5.3+: The current cloud storage tier of a snapshot. A snapshot's cloud storage tier determines how the cloud provider will determine storage and retrieval costs, as well as retrieval latency. Accepted values are Hot, Cool, AzureArchive (with Azure locations), Glacier, and GlacierDeepArchive (for AWS S3 locations). The value Cold has been deprecated in favor of AzureArchive, which is the recommended replacement value.
  

- SNAPSHOT_CLOUD_STORAGE_TIER_AZURE_ARCHIVE
- SNAPSHOT_CLOUD_STORAGE_TIER_COLD
- SNAPSHOT_CLOUD_STORAGE_TIER_COOL
- SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER
- SNAPSHOT_CLOUD_STORAGE_TIER_GLACIER_DEEP_ARCHIVE
- SNAPSHOT_CLOUD_STORAGE_TIER_HOT
