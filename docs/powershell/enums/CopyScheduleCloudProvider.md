### CopyScheduleCloudProvider
CopyScheduleCloudProvider is the cloud provider for a copy schedule's cloud
target. It enumerates the fixed set of destinations a copy schedule can move
data to.

- COPY_SCHEDULE_CLOUD_PROVIDER_UNSPECIFIED - Unset provider; rejected at validation.
- COPY_SCHEDULE_CLOUD_PROVIDER_AZ - Azure blob storage.
- COPY_SCHEDULE_CLOUD_PROVIDER_GCP - Google Cloud Storage.
- COPY_SCHEDULE_CLOUD_PROVIDER_S3 - Amazon S3 / S3-compatible.
- COPY_SCHEDULE_CLOUD_PROVIDER_NFSBLOB - NFS-blob; does not support storage tiering.
