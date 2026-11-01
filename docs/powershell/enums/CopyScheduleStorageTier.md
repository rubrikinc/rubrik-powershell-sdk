### CopyScheduleStorageTier
CopyScheduleStorageTier is the storage tier for moved data on a copy
schedule's cloud target. It is one flat enum whose values are namespaced by
provider family, so the member name alone signals which provider a value
belongs to. It enumerates the fixed set of tiers a copy schedule can use.

- COPY_SCHEDULE_STORAGE_TIER_UNSPECIFIED - Unset tier; valid for any provider (the system applies the provider's
default tier) and the only valid value for NFSBLOB.
- COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD - S3 Standard.
- COPY_SCHEDULE_STORAGE_TIER_S3_STANDARD_IA - S3 Standard-Infrequent Access.
- COPY_SCHEDULE_STORAGE_TIER_S3_ONEZONE_IA - S3 One Zone-Infrequent Access.
- COPY_SCHEDULE_STORAGE_TIER_S3_INTELLIGENT_TIERING - S3 Intelligent-Tiering.
- COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER - S3 Glacier Flexible Retrieval.
- COPY_SCHEDULE_STORAGE_TIER_S3_GLACIER_IR - S3 Glacier Instant Retrieval.
- COPY_SCHEDULE_STORAGE_TIER_S3_DEEP_ARCHIVE - S3 Glacier Deep Archive.
- COPY_SCHEDULE_STORAGE_TIER_AZURE_HOT - Azure Hot tier.
- COPY_SCHEDULE_STORAGE_TIER_AZURE_COOL - Azure Cool tier.
- COPY_SCHEDULE_STORAGE_TIER_AZURE_COLD - Azure Cold tier.
- COPY_SCHEDULE_STORAGE_TIER_AZURE_ARCHIVE - Azure Archive tier.
- COPY_SCHEDULE_STORAGE_TIER_GCP_REGIONAL - GCP Regional storage.
- COPY_SCHEDULE_STORAGE_TIER_GCP_STANDARD - GCP Standard storage.
- COPY_SCHEDULE_STORAGE_TIER_GCP_NEARLINE - GCP Nearline storage.
- COPY_SCHEDULE_STORAGE_TIER_GCP_COLDLINE - GCP Coldline storage.
- COPY_SCHEDULE_STORAGE_TIER_GCP_DURABLE_REDUCED_AVAILABILITY - GCP Durable Reduced Availability storage.
- COPY_SCHEDULE_STORAGE_TIER_GCP_ARCHIVE - GCP Archive storage.
