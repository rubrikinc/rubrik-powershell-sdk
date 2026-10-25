### CloudStorageRehydrationSpeed
Specifies the retrieval speed option when retrieving data from the cold storage tier to the hot storage tier for restore purposes. Rubrik cannot directly restore data from the cold storage tier and the data must be first retrieved into the hot storage tier. This is applicable only for AWS S3 and Azure archival locations. For AWS, three speed options are supported -- AwsExpedited, AwsStandard, and AwsBulk. AwsBulk is the cheapest and slowest. AwsExpedited is the fastest and most expensive. AwsStandard is the recommended default value. For Azure, the options are AzureStandard and AzureHighPriority. AzureHighPriority is more expensive and faster than AzureStandard. The default value is AzureStandard.

- CLOUD_STORAGE_REHYDRATION_SPEED_AWS_BULK - AWS bulk retrieval. The cheapest and slowest option.
- CLOUD_STORAGE_REHYDRATION_SPEED_AWS_EXPEDITED - AWS expedited retrieval. The fastest and most expensive option.
- CLOUD_STORAGE_REHYDRATION_SPEED_AWS_STANDARD - AWS standard retrieval. The recommended default for AWS.
- CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_HIGH_PRIORITY - Azure high-priority rehydration. Faster and more expensive than Azure standard.
- CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_STANDARD - Azure standard rehydration. The default for Azure.
